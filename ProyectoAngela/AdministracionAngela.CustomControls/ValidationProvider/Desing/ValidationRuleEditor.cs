#region Copyright � 2005 Noogen Technologies Inc.
// Author:
//	Tommy Noogen (tom@noogen.net)
//
// (C) 2005 Noogen Technologies Inc. (http://www.noogen.net)
// 
// MIT X.11 LICENSE
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// 
#endregion

using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Windows.Forms.Design;

namespace AdministracionAngela.CustomControls.ValidationProvider.Design
{
	internal class ValidationRuleEditor : UITypeEditor
	{
		/// <summary>
		/// Setup to display our ValidationRuleDesignForm
		/// </summary>
		/// <param name="context"></param>
		/// <param name="provider"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			if ((context != null) && (provider != null))
			{				
				// get ValidationProvider name - "ValidationRule on validationProvider1"
				string sValidationProviderName = context.PropertyDescriptor.DisplayName.Split(' ')[2];

				// find component matches provider name
				ValidationProvider valueVP = null;
				foreach(IComponent c in context.Container.Components)
				{
					valueVP = c as ValidationProvider;
					if ((valueVP != null) && (valueVP.Site.Name == sValidationProviderName))
						break;
				}

				// get component that are selected
				object[] selectedComponents = context.Instance as object[];
				if (selectedComponents == null)
				{
					selectedComponents = new object[] { context.Instance };
				}

				// create ValidationRuleDesignForm 
				ValidationRuleDesignForm vrdf = new ValidationRuleDesignForm((IDesignerHost) provider.GetService(typeof(IDesignerHost)), valueVP, selectedComponents);
				vrdf.ShowDialog();

				// reselect the component on the UI
				ISelectionService selectionService = (ISelectionService) provider.GetService(typeof(ISelectionService));
				selectionService.SetSelectedComponents(selectedComponents);
			}
			return base.EditValue(context, provider, value);
		}

		/// <summary>
		/// Tell designer that our editor is a Modal Form.
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
		{
			if (context != null) return UITypeEditorEditStyle.Modal;
			return base.GetEditStyle(context);

		}
	}
 
}
