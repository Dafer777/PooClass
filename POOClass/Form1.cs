using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Escriba el nombre del paciente";
            button1.Text = "Agregar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient paciente = new Patient();
            paciente.setName(txtName.Text);
            paciente.setSick(txtSick.Text);
            paciente.setYears(txtYears.Text);
            paciente.setNumber(txtNumber.Text);

            //agregar datos a ListBox
            listBox1.Items.Add(paciente.getDates());

            //limpiar los textBox
            txtName.Text="";
            txtSick.Text="";
            txtYears.Text="";
            txtNumber.Text="";
            txtName.Focus();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Limpiar el TextBox
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
