
namespace topbar
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passbookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chequeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attachmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.passbookToolStripMenuItem,
            this.chequeToolStripMenuItem,
            this.attachmentToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1093, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.homeToolStripMenuItem.Text = "Top";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // passbookToolStripMenuItem
            // 
            this.passbookToolStripMenuItem.Name = "passbookToolStripMenuItem";
            this.passbookToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.passbookToolStripMenuItem.Text = "Right";
            this.passbookToolStripMenuItem.Click += new System.EventHandler(this.passbookToolStripMenuItem_Click);
            // 
            // chequeToolStripMenuItem
            // 
            this.chequeToolStripMenuItem.Name = "chequeToolStripMenuItem";
            this.chequeToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.chequeToolStripMenuItem.Text = "Left";
            this.chequeToolStripMenuItem.Click += new System.EventHandler(this.chequeToolStripMenuItem_Click);
            // 
            // attachmentToolStripMenuItem
            // 
            this.attachmentToolStripMenuItem.Name = "attachmentToolStripMenuItem";
            this.attachmentToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.attachmentToolStripMenuItem.Text = "Bottom";
            this.attachmentToolStripMenuItem.Click += new System.EventHandler(this.attachmentToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.aboutToolStripMenuItem.Text = "Float";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 26);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passbookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chequeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attachmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

