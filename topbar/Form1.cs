using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace topbar
{
    public partial class Form1 : ShellLib.ApplicationDesktopToolbar
    {
        public Form1()
        {
            InitializeComponent();
            //this.MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, 25 );

        }
        [STAThread]
        private void Form1_Load(object sender, EventArgs e)
        {

            
            this.Edge = AppBarEdges.Top;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Edge = AppBarEdges.Float;
            this.TopMost = true;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Edge = AppBarEdges.Top;
        }

        private void attachmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Edge = AppBarEdges.Bottom;
        }

        private void passbookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Edge = AppBarEdges.Right;
        }

        private void chequeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Edge = AppBarEdges.Left;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
