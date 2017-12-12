/*
 * Created by SharpDevelop.
 * User: Carlos
 * Date: 11/12/2017
 * Time: 09:44 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace ej3
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		DataSet ds;
		DataTable cli;
		DataTable ord;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			cli = new DataTable("Clientes");
			cli.Columns.Add("idCliente", typeof(int));
			cli.Columns.Add("Apellido", typeof(string));
			cli.Columns.Add("Nombre", typeof(string));
			cli.Columns.Add("Direccion", typeof(string));
			cli.Columns.Add("Telefono", typeof(string));
			
			ord = new DataTable("Ordenes");
			ord.Columns.Add("idCliente", typeof(int));
			ord.Columns.Add("idOrden", typeof(int));
			ord.Columns.Add("Fecha", typeof(DateTime));
			ord.Columns.Add("Detalle", typeof(string));
			
			ds = new DataSet("dataSet");
			ds.Tables.Add(cli);
			ds.Tables.Add(ord);
			ds.Relations.Add(new DataRelation("relacion",cli.Columns["idCliente"],ord.Columns["idCliente"]));
			
			cli.Rows.Add(1, "Perez", "Juan", "la plata", "123456789");
			ord.Rows.Add(1, 1, DateTime.Now, "hola juan");
			ord.Rows.Add(1, 2, DateTime.Now, "hola juan otra vez");
			ord.Rows.Add(1, 3, DateTime.Now, "chau juan");

			cli.Rows.Add(2, "Arbol", "Luca", "la pampa", "555555555");
			ord.Rows.Add(2, 4, DateTime.Now, "hola luca");
			ord.Rows.Add(2, 5, DateTime.Now, "chau arbol");

			cli.Rows.Add(3, "Gonzales", "Elmo", "chubut", "123454321");
			ord.Rows.Add(3, 6, DateTime.Now, "hola elmo?");
			ord.Rows.Add(3, 7, DateTime.Now, "hola genzales");
			ord.Rows.Add(3, 8, DateTime.Now, "chau elmo?");
			ord.Rows.Add(3, 9, DateTime.Now, "chau elmo otra vez");				
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			bindingSource1.DataSource = ds.Tables["Clientes"];
			dataGridView1.DataSource = bindingSource1;
			
			dataGridView2.DataSource = bindingSource1;
			dataGridView2.DataMember = "relacion";
		}
		void DataGridView1DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			MessageBox.Show("Error, dato ingresado invalido!\nDetalles del error:\n" + e.Context.ToString() + ".");
		}
	}
}
