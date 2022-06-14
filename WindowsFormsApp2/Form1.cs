using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApplication1.gestionvta;
using WindowsFormsApp2.Conn;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Facturasvtas fact=new Facturasvtas();
        public List<Productos> products = new List<Productos>();
        public Form1()
        {
            InitializeComponent();

            fact.Detalledctos.Add(new Detalledctos());
            // conexion de dos vias.
            sfDataGrid1.DataSource = fact.Detalledctos.ToList();
            



        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            products = await ConnProducto.ListarAsync();
            comboBox1.DataSource = products;
            ((GridComboBoxColumn)sfDataGrid1.Columns["Idproductos"]).DataSource = products;
        }

        private async void button1_Click(object sender, EventArgs e) 
        {
            //fact.Idfactvta = Convert.ToInt32(textBox1.Text);
            fact.Rut = textBox2.Text;
            fact.Detalledctos = (ICollection<Detalledctos>)sfDataGrid1.DataSource;
            var resultado=await Conn.ConnFacturaVta.Insertar(fact);


        }

        private void sfDataGrid1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fact.Detalledctos.Add(new Detalledctos());
            sfDataGrid1.DataSource = null;
            sfDataGrid1.DataSource = fact.Detalledctos;
            sfDataGrid1.Refresh();
            sfDataGrid1.View.Refresh();
        }
    }
}
