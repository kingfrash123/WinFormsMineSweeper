using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MineSweeper
{
    public partial class customForm : Form
    {
        public customForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Form2 f = null;
        private void ok_Click(object sender, EventArgs e)
        {
            int row = Int32.Parse(rowBox.Text);
            int col = Int32.Parse(colBox.Text);
            int mines = Int32.Parse(minesBox.Text);
            string text = "Custom";

            int size = Math.Min(30, 1000 / Math.Max(row, col));
            if(row> 0 && col > 0 && mines >0 && (row*col>18) && (mines <= (row * col) / 2))
            {
                f = new Form2(text, row, col, size, mines);
                this.AddOwnedForm(f);
                f.Show();
            }
            else
            {
                MessageBox.Show("Invalid Perameters");
            }
                
        }
        private void close_click(object sender, EventArgs e)

        {
            foreach (Form f in this.OwnedForms)
                f.Close();
        }

        private void customForm_Load(object sender, EventArgs e)
        {

        }

        private void colBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
