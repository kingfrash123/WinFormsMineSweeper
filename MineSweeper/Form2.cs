using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ClockDisplay.Text = "000";
            timer1.Interval = 1000;//tenth of a second
            
        }

        
        public Form2(String text,int row, int col,int size,int mines) : this(){
            mineBox.Text = mines.ToString();
            this.Text = text;
            field = new Field(row, col,mines);
            this.ClientSize = new Size(col * size, row * size);
            buttons = new Button[row][];
            for (int i = 0; i < row; i++)
                buttons[i] = new Button[col];
            foreach (int i in Enumerable.Range(0,row))
                foreach (int j in Enumerable.Range(0,col))
                {
                    buttons[i][j] = new Button();
                    buttons[i][j].Text = "";
                    buttons[i][j].BackColor = Color.White;
                    buttons[i][j].Name = i + "," + j;
                    buttons[i][j].Size = new Size(size, size);
                    buttons[i][j].Location = new Point(size * j, size * i);
                    buttons[i][j].UseVisualStyleBackColor = false;
                    buttons[i][j].MouseUp += new MouseEventHandler(Button_Click);
                    this.Controls.Add(buttons[i][j]);
                }
        }
            private void Button_Click(object sender, MouseEventArgs e) {
            Button b = (Button)sender;
            int temp = b.Name.IndexOf(",");
            int click_x = Int16.Parse(b.Name.Substring(0, temp));
            int click_y = Int16.Parse(b.Name.Substring(temp + 1));
            int totFlags = int.Parse(mineBox.Text);
            switch (e.Button)
            {
                case MouseButtons.Left:
                    // Left click
                    if (!this.field.Started)
                        this.field.Initialize(click_x, click_y);
                    timer1.Start();
                    int n = this.field.CountMines(click_x, click_y);
                    if (this.field.IsMine(click_x, click_y))
                    {
                        b.BackColor = Color.Red;
                        MessageBox.Show("Game Over! You clicked on a mine!");
                        this.Close();
                        
                        break;
                    }
                    if (this.field.Discovered.Contains(click_x * buttons[0].Length + click_y))
                        break;
                    foreach (int k in this.field.GetSafeIsland(click_x, click_y))
                    {
                        int i = k / buttons[0].Length;
                        int j = k % buttons[0].Length;
                        buttons[i][j].BackColor = Color.LightGray;
                        int m = this.field.CountMines(i, j);
                        if (m > 0) {
                            buttons[i][j].Text = m + "";
                            buttons[i][j].BackColor = Color.LightBlue;
                        }else
                            buttons[i][j].Enabled = false;
                    }
                    if(field.Win())

                        MessageBox.Show(String.Format("Congratulations {0}! You discovered all safe squares in {1} seconds!", MainForm.name, ClockDisplay.Text));
                        
                    break;
                case MouseButtons.Right:
                    // Right click
                    int p = this.field.CountMines(click_x, click_y);
                    if (this.field.Discovered.Contains(click_x * buttons[0].Length + click_y))
                        break;
                    if(field.Flagged.Contains(click_x * buttons[0].Length + click_y))
                    {
                        b.BackColor = Color.White;
                        field.Flagged.Remove(click_x * buttons[0].Length + click_y);
                        totFlags++;
                        mineBox.Text = totFlags.ToString();
                    }
                    else
                    {
                        b.BackColor = Color.Green;
                        field.Flagged.Add(click_x * buttons[0].Length + click_y);

                        totFlags--;
                        mineBox.Text = totFlags.ToString();

                    }
                    break;
                case MouseButtons.Middle:
                    if (!this.field.Discovered.Contains(click_x * buttons[0].Length + click_y))
                        break;
                    int Flagged_Count = 0;
                    
                    foreach (int k in this.field.GetNeighbors(click_x, click_y))
                        if (field.Flagged.Contains(k))
                            Flagged_Count++;
                            //code goes here less flag
                    if (this.field.CountMines(click_x, click_y) != Flagged_Count)
                        break;
                    foreach (int k in this.field.GetNeighbors(click_x, click_y))
                    {
                        if (field.Flagged.Contains(k) || field.Discovered.Contains(k))
              
                            continue;
                        if (this.field.IsMine(k / buttons[0].Length, k % buttons[0].Length))
                        {
                            b.BackColor = Color.Red;
                            MessageBox.Show("Game Over! You clicked on a mine!");
                            this.Close();
                            break;
                        }
                        foreach (int l in this.field.GetSafeIsland(k/ buttons[0].Length, k% buttons[0].Length))
                        {
                            int i = l / buttons[0].Length;
                            int j = l % buttons[0].Length;
                            buttons[i][j].BackColor = Color.LightGray;
                            int m = this.field.CountMines(i, j);
                            if (m > 0)
                            {
                                buttons[i][j].Text = m + "";
                                buttons[i][j].BackColor = Color.LightBlue;
                            }
                            else
                                buttons[i][j].Enabled = false;
                        }
                        if (field.Win())
                            MessageBox.Show(String.Format("Congratulations {0}! You discovered all safe squares in {1} seconds!",MainForm.name,ClockDisplay.Text));
                            
                    }
                    break;
            }
                

        }
        private Button[][] buttons;
        private Field field;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        int oneSec = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            oneSec++;
            ClockDisplay.Text = oneSec.ToString();
            if (int.Parse(ClockDisplay.Text) >= 999)
            {
                ClockDisplay.Text = "999";
            }
        }

        private void Form2_Deactivate(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Exit?", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
