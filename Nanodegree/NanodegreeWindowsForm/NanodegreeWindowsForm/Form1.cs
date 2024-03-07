using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NanodegreeWindowsForm
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(numero1TextBox1.Text);
            int numero2 = Convert.ToInt32(numero2TextBox2.Text);
            int resposta = numero1 - numero2;

            respostaLabel.Text = Convert.ToString(resposta);
        }

        private void somarButton_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(numero1TextBox1.Text);
            int numero2 = Convert.ToInt32(numero2TextBox2.Text);
            int resposta = numero1 + numero2;

            respostaLabel.Text = Convert.ToString(resposta);
        }

        private void multiplicarButton_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(numero1TextBox1.Text);
            int numero2 = Convert.ToInt32(numero2TextBox2.Text);
            int resposta = numero1 * numero2;

            respostaLabel.Text = Convert.ToString(resposta);
        }

        private void dividirButton_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(numero1TextBox1.Text);
            int numero2 = Convert.ToInt32(numero2TextBox2.Text);
            int resposta = numero1 / numero2;

            respostaLabel.Text = Convert.ToString(resposta);
        }

        private void numero1TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numero2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
