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
    public partial class Form2 : Form
    {
        static int seleccionarFila;
        public Form2()
        {
            InitializeComponent();
        }
        void limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox1.Focus();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            object[] registroDatos =
            {
                textBox1.Text, 
                textBox2.Text, 
                textBox3.Text, 
                textBox4.Text,
                textBox5.Text,
                textBox6.Text,
                textBox7.Text,
                textBox8.Text,
                textBox9.Text,
                textBox10.Text,
                textBox11.Text,

            };
            dataGridView1.Rows.Add(registroDatos);

            MessageBox.Show("Alumno Registrado");
            limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                int indice = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows[indice].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[indice].Cells[1].Value = textBox2.Text;
                dataGridView1.Rows[indice].Cells[2].Value = textBox3.Text;
                dataGridView1.Rows[indice].Cells[3].Value = textBox4.Text;
                dataGridView1.Rows[indice].Cells[4].Value = textBox5.Text;
                dataGridView1.Rows[indice].Cells[5].Value = textBox6.Text;
                dataGridView1.Rows[indice].Cells[6].Value = textBox7.Text;
                dataGridView1.Rows[indice].Cells[7].Value = textBox8.Text;
                dataGridView1.Rows[indice].Cells[8].Value = textBox9.Text;
                dataGridView1.Rows[indice].Cells[9].Value = textBox10.Text;
                dataGridView1.Rows[indice].Cells[10].Value = textBox11.Text;

                MessageBox.Show("Información Modificada");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(seleccionarFila>= 0)
                {
                    dataGridView1.Rows.RemoveAt(seleccionarFila);
                    MessageBox.Show("Alumndo Eliminado");
                 
                }
                else
                {
                    MessageBox.Show("No hay alumnos");
                    limpiar();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No hay almunos seleccionados");
                limpiar();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 cambio2 = new Form3();
            cambio2.Show();
        }
    }
}
