using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAIN_WinForms
{
    public partial class MDIForm : Form
    {
        private List<ListView> views;
        private BookList model;
        // allow toolstrip management for children
        public ToolStrip toolStrip
        {
            get { return this.mdiToolStrip; }
        }
        // allow statusstrip management for children
        public StatusStrip statusStrip
        {
            get { return this.mdiStatusStrip; }
        }

        public MDIForm(BookList model)
        {
            this.model = model;
            views = new List<ListView>();
            InitializeComponent();
        }

        private void ChildFromClosing(object sender, FormClosingEventArgs e)
        {
            if (this.views.Count <= 1 && e.CloseReason != CloseReason.MdiFormClosing)
                e.Cancel = true;
            else
                views.Remove((ListView)sender);
        }

        public void DeleteBook(Book book)
        {
            model.Remove(book);
        }

        public void AddBook()
        {
            BookPropertiesEditForm d = new BookPropertiesEditForm();
            if (d.ShowDialog() == DialogResult.OK)
            {
                model.AddBook(d.titleTextBox.Text, d.authorTextBox.Text,
                    d.dateTimePicker.Value,
                    //d.categoryPicker.ToString()
                    ""
                    );
            }
        }

        public void EditBook(Book book)
        {
            BookPropertiesEditForm d = new BookPropertiesEditForm();
            //d.setFieldsTo(book);
            if (d.ShowDialog() == DialogResult.OK)
            {
                model.AddBook(d.titleTextBox.Text, d.authorTextBox.Text,
                    d.dateTimePicker.Value,
                    //d.categoryPicker.ToString()
                    ""
                    );
            }
        }

        private void addToolStripLabel_Click(object sender, EventArgs e)
        {
            AddBook();
        }
    }
}
