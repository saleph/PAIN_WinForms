using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAIN_WinForms
{
    public partial class CategoryChooser : PictureBox
    {
        private static Image criminalImage = Resource1.criminal;
        private static Image fantasyImage = Resource1.fantasy;
        private static Image[] categories = { criminalImage, fantasyImage };
        public enum Category { criminal, fantasy };
        public event EventHandler RaiseEditEvent;

        protected virtual void OnRaiseEditEvent()
        {
            RaiseEditEvent?.Invoke(this, null);
        }
        private Category CurrentCategory;


        [Editor(typeof(CategoryEditor), typeof(System.Drawing.Design.UITypeEditor))]
        [Category("Category")]
        [Browsable(true)]
        public Category BookCategory
        {
            get { return CurrentCategory; }
            set
            {
                this.CurrentCategory = value;
                this.Image = categories[(int)this.CurrentCategory];
                OnRaiseEditEvent();
            }
        }

        public CategoryChooser(Category category)
        {
            InitializeComponent();
            this.Size = new Size(64, 64);
            this.BookCategory = category;
            this.Click += CategoryChooserClicked;
        }

        public CategoryChooser() : this(Category.criminal) { }

        private void CategoryChooserClicked(object sender, EventArgs e)
        {
            this.BookCategory = (Category)(((int)this.BookCategory + 1) % 2);
        }

        public CategoryChooser(IContainer container)
        {
            InitializeComponent();
        }
    }
}
