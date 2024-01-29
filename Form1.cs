using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Cientifica
{
    public partial class Form1 : Form
    {
        double aux1; //Las variables globales
        double aux2;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }
        Clases.claseSuma objSuma = new Clases.claseSuma(); //Instanciando clase

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Pantalla
        }

        private void Form1_Load(object sender, EventArgs e) //Carga
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Numero 1
            textBox1.Text = textBox1.Text + '1';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Numero 8
            textBox1.Text = textBox1.Text + '8';
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //Punto .
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Porciento
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //C
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Elevado a 2
            textBox1.Text = textBox1.Text + '2';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Delete
            textBox1_TextChanged.text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Numero 7
            textBox1.Text = textBox1.Text + '7';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Numero 9
            textBox1.Text = textBox1.Text + '9';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Por *
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Numero 4
            textBox1.Text = textBox1.Text + '4';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Numero 5
            textBox1.Text = textBox1.Text + '5';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Numero 6
            textBox1.Text = textBox1.Text + '6';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Resta -
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Numero 2
            textBox1.Text = textBox1.Text + '2';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Numero 3
            textBox1.Text = textBox1.Text + '3';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Signo De +

            operador = "+";
            aux1 = double.Parse(textBox1.Text);
            textBox1.Clear();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            // Numero 0
            textBox1.Text = textBox1.Text + '0';
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // IGUAL =
            aux2 = double.Parse(textBox1.Text);
            double operacionSuma;
            switch (operador)
            {
                case "+":
                    operacionSuma = objSuma.sumas(aux1,aux2);
                    textBox1.Text = operacionSuma.ToString(); 
                    break;
            }
        }

        private void RAIZ_Click(object sender, EventArgs e)
        {
            //raiz
        }

        private void DIVICION_Click(object sender, EventArgs e)
        {
            //Divicion
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //Potencia
        }

        private void CE_Click(object sender, EventArgs e)
        {

        }
    }
}
