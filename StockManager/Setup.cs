using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Setup_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ControlExtension.Draggable(this, true);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        enum Databases 
        {
            SQLite,
            MongoDB
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            int selectedDatabase = DatabaseSelection.SelectedIndex;
            if (selectedDatabase < 0) return;

            new ChooseColumns().Show();
            this.Hide();
        }
    }
}
