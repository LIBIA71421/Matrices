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
    public partial class _3RA_PREGUNTA : Form
    {
        public _3RA_PREGUNTA()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {//fallo
            MessageBox.Show("PERDIO" + " Suerte en el siguiente");
            this.Hide();
            _3RA_PREGUNTA est = new _3RA_PREGUNTA();
            est.ShowDialog();   
        }
    }
}
