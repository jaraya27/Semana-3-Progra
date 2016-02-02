using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Semana_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Content = true;
            int i = 35;
            string h = "Hola mundo";
            int[] Array = { 5, 10, 15 };
            string valor = "";

            foreach (int numero in Array) 
            {
                valor = valor + ","+ numero + "," + "";
                txthola4.Text = valor;
            }

            TxtHola.Text = Convert.ToString(Content);
            txthola2.Text = Convert.ToString(i);
            txthola3.Text = h;
            
            
            
        
    }
    }
}
