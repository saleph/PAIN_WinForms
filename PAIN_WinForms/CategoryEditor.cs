﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms.Design;
using System.ComponentModel;

namespace PAIN_WinForms
{
    public partial class CategoryEditor : System.Drawing.Design.UITypeEditor
    {
        public override bool GetPaintValueSupported(ITypeDescriptorContext context)
        {
            return false;
        }

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (edSvc != null)
            {
                CategoryChooser genrePicker = new CategoryChooser((CategoryChooser.Category)value);
                edSvc.DropDownControl(genrePicker);
                return genrePicker.BookCategory;
            }
            return value;
        }
    }
}
