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

namespace ej1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
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
			
			if()
			{
				button2.Enabled = false;
				button3.Enabled = false;
			}
		}
		void Button3Click(object sender, EventArgs e)
		{
			//borrar todas las filas
			
			button2.Enabled = false;
			button3.Enabled = false;
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
	}
}
