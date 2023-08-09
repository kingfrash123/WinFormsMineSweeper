namespace MineSweeper
{
    partial class customForm
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
            this.row = new System.Windows.Forms.Label();
            this.mine = new System.Windows.Forms.Label();
            this.colum = new System.Windows.Forms.Label();
            this.rowBox = new System.Windows.Forms.TextBox();
            this.colBox = new System.Windows.Forms.TextBox();
            this.minesBox = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // row
            // 
            this.row.AutoSize = true;
            this.row.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row.Location = new System.Drawing.Point(90, 17);
            this.row.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(76, 36);
            this.row.TabIndex = 0;
            this.row.Text = "Row";
            // 
            // mine
            // 
            this.mine.AutoSize = true;
            this.mine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mine.Location = new System.Drawing.Point(580, 17);
            this.mine.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.mine.Name = "mine";
            this.mine.Size = new System.Drawing.Size(95, 36);
            this.mine.TabIndex = 1;
            this.mine.Text = "Mines";
            this.mine.Click += new System.EventHandler(this.label2_Click);
            // 
            // colum
            // 
            this.colum.AutoSize = true;
            this.colum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colum.Location = new System.Drawing.Point(330, 17);
            this.colum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.colum.Name = "colum";
            this.colum.Size = new System.Drawing.Size(100, 36);
            this.colum.TabIndex = 2;
            this.colum.Text = "Colum";
            // 
            // rowBox
            // 
            this.rowBox.Location = new System.Drawing.Point(28, 58);
            this.rowBox.Margin = new System.Windows.Forms.Padding(6);
            this.rowBox.Name = "rowBox";
            this.rowBox.Size = new System.Drawing.Size(196, 31);
            this.rowBox.TabIndex = 3;
            this.rowBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // colBox
            // 
            this.colBox.Location = new System.Drawing.Point(282, 58);
            this.colBox.Margin = new System.Windows.Forms.Padding(6);
            this.colBox.Name = "colBox";
            this.colBox.Size = new System.Drawing.Size(196, 31);
            this.colBox.TabIndex = 4;
            this.colBox.TextChanged += new System.EventHandler(this.colBox_TextChanged);
            // 
            // minesBox
            // 
            this.minesBox.Location = new System.Drawing.Point(528, 58);
            this.minesBox.Margin = new System.Windows.Forms.Padding(6);
            this.minesBox.Name = "minesBox";
            this.minesBox.Size = new System.Drawing.Size(196, 31);
            this.minesBox.TabIndex = 5;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(308, 129);
            this.ok.Margin = new System.Windows.Forms.Padding(6);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(150, 44);
            this.ok.TabIndex = 6;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // customForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 196);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.minesBox);
            this.Controls.Add(this.colBox);
            this.Controls.Add(this.rowBox);
            this.Controls.Add(this.colum);
            this.Controls.Add(this.mine);
            this.Controls.Add(this.row);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "customForm";
            this.Text = "customForm";
            this.Load += new System.EventHandler(this.customForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label row;
        private System.Windows.Forms.Label mine;
        private System.Windows.Forms.Label colum;
        private System.Windows.Forms.TextBox rowBox;
        private System.Windows.Forms.TextBox colBox;
        private System.Windows.Forms.TextBox minesBox;
        private System.Windows.Forms.Button ok;
    }
}