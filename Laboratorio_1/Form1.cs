using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_1
{
    public partial class Form1 : Form
    {
        Decola mensajero = new Decola();

        public void mostrarCola()
        {
            listView1.Clear();
            for (int i = 0; i <= mensajero.ultimo; i++)
            {
                listView1.Items.Add(mensajero.lista[i].ToString());

            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        

        private void button1_Click(object sender, EventArgs e)
        {
            mensajero.insertar_primero(Int32.Parse(textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();
            mostrarCola();

        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            mensajero.eliminar_ultimo();
            mostrarCola();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mensajero.insertar_ultimo(Int32.Parse(textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();
            mostrarCola();
        }
    }
}
