using System;
using System.Windows.Forms;

namespace StockManager
{
    public partial class ChooseColumns : Form
    {
        private int database;

        public ChooseColumns(int database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ControlExtension.Draggable(this, true);
            }
        }

    }
}
