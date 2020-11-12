namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_00 = new System.Windows.Forms.Button();
            this.btn_02 = new System.Windows.Forms.Button();
            this.btn_01 = new System.Windows.Forms.Button();
            this.btn_11 = new System.Windows.Forms.Button();
            this.btn_12 = new System.Windows.Forms.Button();
            this.btn_21 = new System.Windows.Forms.Button();
            this.btn_22 = new System.Windows.Forms.Button();
            this.btn_20 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_10 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sudoku = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_00
            // 
            this.btn_00.BackColor = System.Drawing.Color.Cyan;
            this.btn_00.Font = new System.Drawing.Font("Lucida Sans Unicode", 30.25F, System.Drawing.FontStyle.Bold);
            this.btn_00.Location = new System.Drawing.Point(16, 13);
            this.btn_00.Name = "btn_00";
            this.btn_00.Size = new System.Drawing.Size(128, 100);
            this.btn_00.TabIndex = 0;
            this.btn_00.Tag = "0,0";
            this.btn_00.UseVisualStyleBackColor = false;
            this.btn_00.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_02
            // 
            this.btn_02.BackColor = System.Drawing.Color.Cyan;
            this.btn_02.Font = new System.Drawing.Font("Lucida Sans Unicode", 30.25F, System.Drawing.FontStyle.Bold);
            this.btn_02.Location = new System.Drawing.Point(304, 14);
            this.btn_02.Name = "btn_02";
            this.btn_02.Size = new System.Drawing.Size(128, 100);
            this.btn_02.TabIndex = 1;
            this.btn_02.Tag = "0,2";
            this.btn_02.UseVisualStyleBackColor = false;
            this.btn_02.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_01
            // 
            this.btn_01.BackColor = System.Drawing.Color.Cyan;
            this.btn_01.Font = new System.Drawing.Font("Lucida Sans Unicode", 30.25F, System.Drawing.FontStyle.Bold);
            this.btn_01.Location = new System.Drawing.Point(160, 14);
            this.btn_01.Name = "btn_01";
            this.btn_01.Size = new System.Drawing.Size(128, 100);
            this.btn_01.TabIndex = 2;
            this.btn_01.Tag = "0,1";
            this.btn_01.UseVisualStyleBackColor = false;
            this.btn_01.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_11
            // 
            this.btn_11.BackColor = System.Drawing.Color.Cyan;
            this.btn_11.Font = new System.Drawing.Font("Lucida Sans Unicode", 30.25F, System.Drawing.FontStyle.Bold);
            this.btn_11.Location = new System.Drawing.Point(160, 123);
            this.btn_11.Name = "btn_11";
            this.btn_11.Size = new System.Drawing.Size(128, 100);
            this.btn_11.TabIndex = 5;
            this.btn_11.Tag = "1,1";
            this.btn_11.UseVisualStyleBackColor = false;
            this.btn_11.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_12
            // 
            this.btn_12.BackColor = System.Drawing.Color.Cyan;
            this.btn_12.Font = new System.Drawing.Font("Lucida Sans Unicode", 30.25F, System.Drawing.FontStyle.Bold);
            this.btn_12.Location = new System.Drawing.Point(304, 123);
            this.btn_12.Name = "btn_12";
            this.btn_12.Size = new System.Drawing.Size(128, 100);
            this.btn_12.TabIndex = 4;
            this.btn_12.Tag = "1,2";
            this.btn_12.UseVisualStyleBackColor = false;
            this.btn_12.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_21
            // 
            this.btn_21.BackColor = System.Drawing.Color.Cyan;
            this.btn_21.Font = new System.Drawing.Font("Lucida Sans Unicode", 30.25F, System.Drawing.FontStyle.Bold);
            this.btn_21.Location = new System.Drawing.Point(160, 236);
            this.btn_21.Name = "btn_21";
            this.btn_21.Size = new System.Drawing.Size(128, 100);
            this.btn_21.TabIndex = 8;
            this.btn_21.Tag = "2,1";
            this.btn_21.UseVisualStyleBackColor = false;
            this.btn_21.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_22
            // 
            this.btn_22.BackColor = System.Drawing.Color.Cyan;
            this.btn_22.Font = new System.Drawing.Font("Lucida Sans Unicode", 30.25F, System.Drawing.FontStyle.Bold);
            this.btn_22.Location = new System.Drawing.Point(304, 236);
            this.btn_22.Name = "btn_22";
            this.btn_22.Size = new System.Drawing.Size(128, 100);
            this.btn_22.TabIndex = 7;
            this.btn_22.Tag = "2,2";
            this.btn_22.UseVisualStyleBackColor = false;
            this.btn_22.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_20
            // 
            this.btn_20.BackColor = System.Drawing.Color.Cyan;
            this.btn_20.Font = new System.Drawing.Font("Lucida Sans Unicode", 30.25F, System.Drawing.FontStyle.Bold);
            this.btn_20.Location = new System.Drawing.Point(16, 235);
            this.btn_20.Name = "btn_20";
            this.btn_20.Size = new System.Drawing.Size(128, 100);
            this.btn_20.TabIndex = 6;
            this.btn_20.Tag = "2,0";
            this.btn_20.UseVisualStyleBackColor = false;
            this.btn_20.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btn_11);
            this.panel1.Controls.Add(this.btn_21);
            this.panel1.Controls.Add(this.btn_00);
            this.panel1.Controls.Add(this.btn_22);
            this.panel1.Controls.Add(this.btn_02);
            this.panel1.Controls.Add(this.btn_20);
            this.panel1.Controls.Add(this.btn_01);
            this.panel1.Controls.Add(this.btn_10);
            this.panel1.Controls.Add(this.btn_12);
            this.panel1.Location = new System.Drawing.Point(48, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 353);
            this.panel1.TabIndex = 9;
            // 
            // btn_10
            // 
            this.btn_10.BackColor = System.Drawing.Color.Cyan;
            this.btn_10.Font = new System.Drawing.Font("Lucida Sans Unicode", 30.25F, System.Drawing.FontStyle.Bold);
            this.btn_10.Location = new System.Drawing.Point(16, 122);
            this.btn_10.Name = "btn_10";
            this.btn_10.Size = new System.Drawing.Size(128, 100);
            this.btn_10.TabIndex = 3;
            this.btn_10.Tag = "1,0";
            this.btn_10.UseVisualStyleBackColor = false;
            this.btn_10.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(585, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 344);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "JUGADORES";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(176, 228);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 36);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 36);
            this.textBox1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(40, 198);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(40, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(124, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "TIC TAC TOE";
            // 
            // btn_sudoku
            // 
            this.btn_sudoku.BackColor = System.Drawing.Color.Black;
            this.btn_sudoku.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sudoku.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_sudoku.Location = new System.Drawing.Point(552, 42);
            this.btn_sudoku.Name = "btn_sudoku";
            this.btn_sudoku.Size = new System.Drawing.Size(286, 40);
            this.btn_sudoku.TabIndex = 16;
            this.btn_sudoku.Text = "PREFIERO SUDOKU";
            this.btn_sudoku.UseVisualStyleBackColor = false;
            this.btn_sudoku.Click += new System.EventHandler(this.btn_sudoku_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(992, 499);
            this.Controls.Add(this.btn_sudoku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_00;
        private System.Windows.Forms.Button btn_02;
        private System.Windows.Forms.Button btn_01;
        private System.Windows.Forms.Button btn_11;
        private System.Windows.Forms.Button btn_12;
        private System.Windows.Forms.Button btn_21;
        private System.Windows.Forms.Button btn_22;
        private System.Windows.Forms.Button btn_20;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sudoku;
    }
}

