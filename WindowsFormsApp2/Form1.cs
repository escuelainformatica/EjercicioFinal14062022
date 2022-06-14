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
        public List<Facturasvtas> facturas = new List<Facturasvtas>();
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

            ((GridComboBoxColumn)sfDataGrid1.Columns["Idproductos"]).DataSource = products;

            facturas = await ConnFacturaVta.ListarAsync();
            sfDataGridListado.DataSource = facturas;
            
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

        private void sfDataGrid1_CellButtonClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellButtonClickEventArgs e)
        {
            int fila = e.RowIndex - 1;
            var elem=fact.Detalledctos.ElementAt(fila);
            fact.Detalledctos.Remove(elem);

            sfDataGrid1.DataSource = null;
            sfDataGrid1.DataSource = fact.Detalledctos;
            sfDataGrid1.Refresh();
            sfDataGrid1.View.Refresh();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInsertar.Visible = true;
            panelListado.Visible = false;
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInsertar.Visible = false;
            panelListado.Visible = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sfDataGridListado_CellClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            int fila = e.DataRow.Index - 1;
            Facturasvtas elem = facturas.ElementAt(fila);
            // mostrar la factura
            textBox3.Text = elem.Idfactvta.ToString();
            sfDataGridDetalle.DataSource = null;
            sfDataGridDetalle.DataSource = elem.Detalledctos;



        }
    }
}
