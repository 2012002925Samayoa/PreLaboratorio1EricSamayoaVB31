using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreLaboratorio1EricSamayoaVB31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if(textBox1.Text == "6789")
                {
                    MessageBox.Show("Contraseña Correcta");

                    Form2 cambio = new Form2();
                    cambio.Show();
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta");

                    textBox1.Clear();
                }
            }

        }
    }
}
