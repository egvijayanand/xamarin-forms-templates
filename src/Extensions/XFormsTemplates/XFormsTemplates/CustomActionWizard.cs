using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.IO;

namespace VijayAnand.XFormsTemplates
{
	public class CustomActionWizard : IWizard
	{
		bool xamlOnly;
		bool userCancel;

		/// <summary>This method is called before opening any item that has the OpenInEditor attribute.</summary>
		public void BeforeOpeningFile(ProjectItem projectItem)
		{

		}

		public void ProjectFinishedGenerating(Project project)
		{

		}

		/// <summary>This method is only called for item templates, not for project templates.</summary>
		public void ProjectItemFinishedGenerating(ProjectItem projectItem)
		{

		}

		/// <summary>This method is called after the project is created.</summary>
		public void RunFinished()
		{

		}

		public async void RunStarted(object automationObject,
									 Dictionary<string, string> replacementsDictionary,
									 WizardRunKind runKind,
									 object[] customParams)
		{
			try
			{
				//ThreadHelper.ThrowIfNotOnUIThread();
				await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();

				if (runKind == WizardRunKind.AsNewItem)
				{
					if (replacementsDictionary.ContainsKey("$basetype$"))
					{
						var xamlItem = replacementsDictionary.ContainsKey("$xaml$");
						var window = new GenericItemDialog(xamlItem);
						var result = window.ShowDialog();

						if (result is true)
						{
							xamlOnly = window.XamlOnly;
							replacementsDictionary["$xaml$"] = xamlOnly.ToString().ToLowerInvariant();

							var baseType = window.BaseType;
							var genericType = window.GenericType;
							var baseTypeCS = baseType.Contains(":") ? baseType.Substring(baseType.IndexOf(':') + 1) : baseType;
							var genericTypeCS = genericType.Contains(":") ? genericType.Substring(genericType.IndexOf(':') + 1) : genericType;

							if (!string.IsNullOrEmpty(baseType))
							{
								if (xamlItem)
								{
									replacementsDictionary["$basetype$"] = baseType;

									if (string.IsNullOrEmpty(genericTypeCS))
									{
										replacementsDictionary["$csbasetype$"] = baseTypeCS;
										replacementsDictionary["$generic$"] = bool.FalseString.ToLowerInvariant();
									}
									else
									{
										replacementsDictionary["$csbasetype$"] = $"{baseTypeCS}<{genericTypeCS}>";
										replacementsDictionary["$generic$"] = bool.TrueString.ToLowerInvariant();
										replacementsDictionary["$typearg$"] = genericType;
									}
								}
								else
								{
									// For C# template, basetype is the parameter name
									if (string.IsNullOrEmpty(genericTypeCS))
									{
										replacementsDictionary["$basetype$"] = baseTypeCS;
									}
									else
									{
										replacementsDictionary["$basetype$"] = $"{baseTypeCS}<{genericTypeCS}>";
									}
								}
							}
						}
						else
						{
							userCancel = true;
						}
					}
				}
			}
			catch (Exception ex)
			{
				// Log the exception.
				await ex.LogAsync();
			}
		}

		/// <summary>This method is only called for item templates, not for project templates.</summary>
		public bool ShouldAddProjectItem(string filePath)
		{
			if (userCancel)
			{
				return false;
			}
			else if (filePath.EndsWith(".xaml.cs"))
			{
				return !xamlOnly;
			}
			else
			{
				return !File.Exists(filePath);
			}
		}
	}
}
