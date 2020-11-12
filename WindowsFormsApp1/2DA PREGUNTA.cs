using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class _2DA_PREGUNTA : Form
    {
        public _2DA_PREGUNTA()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {//buena
            MessageBox.Show("!!! BIEN HECHO !!!!" + " >> Continuemos Jugando << ");
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {//fallo
            MessageBox.Show("PERDIO" + " Suerte en el siguiente");
            this.Hide();
            _3RA_PREGUNTA est = new _3RA_PREGUNTA();
            est.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {//fallo
            MessageBox.Show("PERDIO" + " Suerte en el siguiente");
            this.Hide();
            _3RA_PREGUNTA est = new _3RA_PREGUNTA();
            est.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {//fallo
            MessageBox.Show("PERDIO" + " Suerte en el siguiente");
            this.Hide();
            _3RA_PREGUNTA est = new _3RA_PREGUNTA();
            est.ShowDialog();
        }
    }
}
