using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp1
{
    partial class FIN_DEL_JUEGO
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
            this.lbl_ganador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ganador
            // 
            this.lbl_ganador.AutoSize = true;
            this.lbl_ganador.Font = new System.Drawing.Font("Snap ITC", 35F, System.Drawing.FontStyle.Italic);
            this.lbl_ganador.Location = new System.Drawing.Point(40, 138);
            this.lbl_ganador.Name = "lbl_ganador";
            this.lbl_ganador.Size = new System.Drawing.Size(963, 122);
            this.lbl_ganador.TabIndex = 7;
            this.lbl_ganador.Text = "......>> !!! FELICIDADES !!! <<.....\r\n>> !!! GANASTE EL JUEGO !!! <<";
            // 
            // FIN_DEL_JUEGO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1063, 450);
            this.Controls.Add(this.lbl_ganador);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "FIN_DEL_JUEGO";
            this.Text = "FIN_DEL_JUEGO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ganador;
    }
}