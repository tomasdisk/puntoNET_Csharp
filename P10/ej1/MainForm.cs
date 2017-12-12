/*
 * Created by SharpDevelop.
 * User: Carlos
 * Date: 11/12/2017
 * Time: 09:43 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace ej1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		DataTable tabla;
		Form f;
		Button b1;
		Button b2;
		Label l1;
		ComboBox cb1;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//crear tabla
			tabla = new DataTable("tabla");
			tabla.Columns.Add("Nombre", typeof(string));
			tabla.Columns.Add("Apellido", typeof(string));
			tabla.Columns.Add("Edad", typeof(int));
			
			button1.Enabled = false;
			button2.Enabled = false;
			button3.Enabled = false;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			int r;
			if(int.TryParse(textBox3.Text,out r))
			{
				if(r >= 0)
				{
					//agregar
					tabla.Rows.Add(textBox1.Text, textBox2.Text, r);
					textBox1.Text = "";
					textBox2.Text = "";
					textBox3.Text = "";
					button1.Enabled = false;
					button2.Enabled = true;
					button3.Enabled = true;
				}
				else
				{
					// mostras aviso
					MessageBox.Show("La edad no puede ser negativa.","Edad invalida",MessageBoxButtons.OK);	
				}	
			}
			else
			{
				// mostras aviso
				MessageBox.Show("La edad ingresada no es correcta.","Edad invalida",MessageBoxButtons.OK);	
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			//crear custom form f
			f = new Form();
			f.Size = new Size(280,180);
			f.MaximizeBox = false;
			f.MaximumSize = new Size(280,180);
			f.MinimumSize = new Size(280,180);
			f.Text = "Borrar Fila ...";
			//boton 1 para f
			b1 = new Button();
			b1.Location = new System.Drawing.Point(170, 30);
			b1.Name = "b1";
			b1.Size = new System.Drawing.Size(78, 23);
			b1.TabIndex = 0;
			b1.Text = "Eliminar";
			b1.UseVisualStyleBackColor = true;
			b1.Click += new System.EventHandler(EliminarClick);
			//boton 1 para f
			b2 = new Button();
			b2.Location = new System.Drawing.Point(170, 90);
			b2.Name = "b2";
			b2.Size = new System.Drawing.Size(78, 23);
			b2.TabIndex = 1;
			b2.Text = "Cancelar";
			b2.UseVisualStyleBackColor = true;
			b2.Click += new System.EventHandler(CancelarClick);
			//label para f
			l1 = new Label();
			l1.Location = new System.Drawing.Point(30, 30);
			l1.Name = "l1";
			l1.Size = new System.Drawing.Size(120, 50);
			l1.TabIndex = 2;
			l1.Text = "Indique el número de fila que desea eliminar de la tabla:";
			l1.ForeColor = Color.Red;
			//comboBox para f
			cb1 = new ComboBox();
			cb1.FormattingEnabled = true;
			cb1.Location = new System.Drawing.Point(30, 90);
			cb1.Name = "cb1";
			cb1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cb1.Size = new System.Drawing.Size(120, 21);
			cb1.TabIndex = 3;
			for (int i = 0; i < tabla.Rows.Count; i++)
			{
				cb1.Items.Add("Fila " + i);
			}
			cb1.SelectedIndex = 0;
			//mostar f
			f.Controls.Add(b1);
			f.Controls.Add(b2);
			f.Controls.Add(l1);
			f.Controls.Add(cb1);
			f.ShowDialog();
				
			//verificar estado de botones
			if(tabla.Rows.Count == 0)
			{
				button2.Enabled = false;
				button3.Enabled = false;
			}
		}
		void EliminarClick(object sender, EventArgs e)
		{
			tabla.Rows.RemoveAt(cb1.SelectedIndex);
			f.Close();
		}
		void CancelarClick(object sender, EventArgs e)
		{
			f.Close();
		}
		void Button3Click(object sender, EventArgs e)
		{
			//borrar todas las filas
			if (MessageBox.Show("¿Desea eliminar todas las filas?","Borrar Todo",MessageBoxButtons.YesNo) == DialogResult.Yes) {
				tabla.Rows.Clear();
				button2.Enabled = false;
				button3.Enabled = false;
			}
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
			{
				button1.Enabled = true;
			}
			else
			{
				button1.Enabled = false;
			}
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			dataGridView1.DataSource = tabla;
		}
	}
}
