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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        FormCollection fc = System.Windows.Forms.Application.OpenForms;
        public static string name = "";
        public static int openGames = 0;
        public bool idle = true;
        int nonGames = 0;
        


        public void less()
        {
            openGames--;
            numGames.Text = openGames.ToString();
        }
        private void Play(object sender, EventArgs e)
        {
            name = nameBox.Text;

            int row=0, col=0,mines = 0;//row*col >=18, mines <= row*col/2
            String text = "";
            Form2 f = null;

            customForm c = null;
            if (easy.Checked)
            {
                row = col = 9;
                mines = 10;
                text = "Easy";
                
            }
            else if (medium.Checked)
            {
                row = col = 16;
                mines = 40;
                text = "Medium";
                
            }
            else if (expert.Checked)
            {
                row = 16;
                col = 30;
                mines = 99;
                text = "Expert";
                
            }
            else if (custom.Checked)
            {
                //nonGames++;
                text = "Custom";
                c = new customForm();
                this.AddOwnedForm(c);
                c.Show();
            }
            else
                return;
            if (text != "Custom")
            {
                int size = Math.Min(30, 1000 / Math.Max(row, col));
                f = new Form2(text, row, col, size, mines);
                this.AddOwnedForm(f);
                f.Show();
                //openGames += 1;
                //numGames.Text = openGames.ToString();
                //numGames.Text = Application.OpenForms.Count.ToString();
            }
            

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void close_click(object sender, EventArgs e)
        {
            foreach (Form f in this.OwnedForms)
                f.Close();
            //nonGames = 1;
            //openGames = Application.OpenForms.Count - nonGames;
            //numGames.Text = openGames.ToString();
            gameCounter();
        }

        public void gameCounter()
        {
            nonGames = 0;
            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "MainForm")
                {
                    nonGames++;
                }
                if (frm.Name == "customForm")
                {
                    nonGames++;
                }
            }
            openGames = System.Windows.Forms.Application.OpenForms.Count - nonGames;
            numGames.Text = openGames.ToString();
        }

        private void numGames_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void in_foucs(object sender, EventArgs e)
        {
            gameCounter();

        }

        private void custom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void esasy_click(object sender, EventArgs e)
        {
            name = nameBox.Text;

            int row = 0, col = 0, mines = 0;//row*col >=18, mines <= row*col/2
            String text = "";
            Form2 f = null;

            row = col = 9;
            mines = 10;
            text = "Easy";

            int size = Math.Min(30, 1000 / Math.Max(row, col));
            f = new Form2(text, row, col, size, mines);
            this.AddOwnedForm(f);
            f.Show();
        }

        private void med_button(object sender, EventArgs e)
        {
            name = nameBox.Text;

            int row = 0, col = 0, mines = 0;//row*col >=18, mines <= row*col/2
            String text = "";
            Form2 f = null;

            row = col = 16;
            mines = 40;
            text = "Medium";

            int size = Math.Min(30, 1000 / Math.Max(row, col));
            f = new Form2(text, row, col, size, mines);
            this.AddOwnedForm(f);
            f.Show();
        }

        private void ex_button(object sender, EventArgs e)
        {
            name = nameBox.Text;

            int row = 0, col = 0, mines = 0;//row*col >=18, mines <= row*col/2
            String text = "";
            Form2 f = null;

            row = 16;
            col = 30;
            mines = 99;
            text = "Expert";

            int size = Math.Min(30, 1000 / Math.Max(row, col));
            f = new Form2(text, row, col, size, mines);
            this.AddOwnedForm(f);
            f.Show();
        }

        private void exit_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
