namespace WindowsFormsApp1
{
    partial class SUDOKU
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_verif = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_nivel = new System.Windows.Forms.Label();
            this.rb_bajo = new System.Windows.Forms.RadioButton();
            this.rb_intermedio = new System.Windows.Forms.RadioButton();
            this.rb_alto = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 426);
            this.panel1.TabIndex = 0;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.Black;
            this.btn_limpiar.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_limpiar.Location = new System.Drawing.Point(627, 122);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(143, 40);
            this.btn_limpiar.TabIndex = 17;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_verif
            // 
            this.btn_verif.BackColor = System.Drawing.Color.Black;
            this.btn_verif.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verif.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_verif.Location = new System.Drawing.Point(627, 46);
            this.btn_verif.Name = "btn_verif";
            this.btn_verif.Size = new System.Drawing.Size(143, 67);
            this.btn_verif.TabIndex = 18;
            this.btn_verif.Text = "VERIFICACION";
            this.btn_verif.UseVisualStyleBackColor = false;
            this.btn_verif.Click += new System.EventHandler(this.btn_verif_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.Black;
            this.btn_nuevo.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_nuevo.Location = new System.Drawing.Point(627, 315);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(143, 75);
            this.btn_nuevo.TabIndex = 19;
            this.btn_nuevo.Text = "NUEVO JUEGO";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_nivel
            // 
            this.btn_nivel.AutoSize = true;
            this.btn_nivel.Location = new System.Drawing.Point(650, 222);
            this.btn_nivel.Name = "btn_nivel";
            this.btn_nivel.Size = new System.Drawing.Size(38, 13);
            this.btn_nivel.TabIndex = 20;
            this.btn_nivel.Text = "NIVEL";
            // 
            // rb_bajo
            // 
            this.rb_bajo.AutoSize = true;
            this.rb_bajo.Location = new System.Drawing.Point(642, 243);
            this.rb_bajo.Name = "rb_bajo";
            this.rb_bajo.Size = new System.Drawing.Size(46, 17);
            this.rb_bajo.TabIndex = 21;
            this.rb_bajo.TabStop = true;
            this.rb_bajo.Text = "Bajo";
            this.rb_bajo.UseVisualStyleBackColor = true;
            // 
            // rb_intermedio
            // 
            this.rb_intermedio.AutoSize = true;
            this.rb_intermedio.Location = new System.Drawing.Point(642, 266);
            this.rb_intermedio.Name = "rb_intermedio";
            this.rb_intermedio.Size = new System.Drawing.Size(74, 17);
            this.rb_intermedio.TabIndex = 22;
            this.rb_intermedio.TabStop = true;
            this.rb_intermedio.Text = "Intermedio";
            this.rb_intermedio.UseVisualStyleBackColor = true;
            // 
            // rb_alto
            // 
            this.rb_alto.AutoSize = true;
            this.rb_alto.Location = new System.Drawing.Point(642, 289);
            this.rb_alto.Name = "rb_alto";
            this.rb_alto.Size = new System.Drawing.Size(43, 17);
            this.rb_alto.TabIndex = 23;
            this.rb_alto.TabStop = true;
            this.rb_alto.Text = "Alto";
            this.rb_alto.UseVisualStyleBackColor = true;
            // 
            // SUDOKU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rb_alto);
            this.Controls.Add(this.rb_intermedio);
            this.Controls.Add(this.rb_bajo);
            this.Controls.Add(this.btn_nivel);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_verif);
            this.Controls.Add(this.btn_limpiar);
            this.Name = "SUDOKU";
            this.Text = "SUDOKU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_verif;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Label btn_nivel;
        private System.Windows.Forms.RadioButton rb_bajo;
        private System.Windows.Forms.RadioButton rb_intermedio;
        private System.Windows.Forms.RadioButton rb_alto;
    }
}