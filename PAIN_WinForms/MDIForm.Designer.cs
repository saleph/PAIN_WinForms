namespace PAIN_WinForms
{
    partial class MDIForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mdiMenuStrip = new System.Windows.Forms.MenuStrip();
            this.addNewViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mdiToolStrip = new System.Windows.Forms.ToolStrip();
            this.addToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.mdiStatusStrip = new System.Windows.Forms.StatusStrip();
            this.mdiMenuStrip.SuspendLayout();
            this.mdiToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mdiMenuStrip
            // 
            this.mdiMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewViewToolStripMenuItem,
            this.manageToolStripMenuItem});
            this.mdiMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mdiMenuStrip.Name = "mdiMenuStrip";
            this.mdiMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.mdiMenuStrip.TabIndex = 1;
            this.mdiMenuStrip.Text = "menuStrip1";
            // 
            // addNewViewToolStripMenuItem
            // 
            this.addNewViewToolStripMenuItem.Name = "addNewViewToolStripMenuItem";
            this.addNewViewToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.addNewViewToolStripMenuItem.Text = "Add new view";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripLabel_Click);
            // 
            // mdiToolStrip
            // 
            this.mdiToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripLabel});
            this.mdiToolStrip.Location = new System.Drawing.Point(0, 24);
            this.mdiToolStrip.Name = "mdiToolStrip";
            this.mdiToolStrip.Size = new System.Drawing.Size(800, 25);
            this.mdiToolStrip.TabIndex = 2;
            this.mdiToolStrip.Text = "toolStrip1";
            // 
            // addToolStripLabel
            // 
            this.addToolStripLabel.Name = "addToolStripLabel";
            this.addToolStripLabel.Size = new System.Drawing.Size(29, 22);
            this.addToolStripLabel.Text = "Add";
            this.addToolStripLabel.Click += new System.EventHandler(this.addToolStripLabel_Click);
            // 
            // mdiStatusStrip
            // 
            this.mdiStatusStrip.Location = new System.Drawing.Point(0, 428);
            this.mdiStatusStrip.Name = "mdiStatusStrip";
            this.mdiStatusStrip.Size = new System.Drawing.Size(800, 22);
            this.mdiStatusStrip.TabIndex = 3;
            this.mdiStatusStrip.Text = "statusStrip1";
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mdiStatusStrip);
            this.Controls.Add(this.mdiToolStrip);
            this.Controls.Add(this.mdiMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mdiMenuStrip;
            this.Name = "MDIForm";
            this.Text = "MDIForm";
            this.mdiMenuStrip.ResumeLayout(false);
            this.mdiMenuStrip.PerformLayout();
            this.mdiToolStrip.ResumeLayout(false);
            this.mdiToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mdiMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addNewViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStrip mdiToolStrip;
        private System.Windows.Forms.ToolStripLabel addToolStripLabel;
        private System.Windows.Forms.StatusStrip mdiStatusStrip;
    }
}