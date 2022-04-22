using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalDCU_Felix_Ortega_2021_0825_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 formulario = new Form2();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 formulario = new Form2();
            formulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 formulario = new Form2();
            formulario.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
