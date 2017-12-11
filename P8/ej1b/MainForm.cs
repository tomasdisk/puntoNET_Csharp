/*
 * Created by SharpDevelop.
 * User: tomm
 * Date: 11/12/2017
 * Time: 03:47 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ej1b
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
			label1.Top=panel1.Height / 2 - 25;
			label1.Left=panel1.Width / 2 - 75;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			int v = getTextBox();
			label1.Left -= v;
			label1.Width += v;
			if(label1.Left <= 0){
				label1.Width += label1.Left;
				label1.Left = 0;
				button1.Enabled=false;
			}
			label1.Text="Label de "+ label1.Width +" pixeles de ancho y "+ label1.Height +" pixeles de alto.";
		}
		void Button2Click(object sender, EventArgs e)
		{
			int v = getTextBox();
			label1.Height += v;
			if((label1.Top + label1.Height) >= panel1.Height){
				label1.Height = panel1.Height - label1.Top;
				button2.Enabled=false;
			}
			label1.Text="Label de "+ label1.Width +" pixeles de ancho y "+ label1.Height +" pixeles de alto.";
		}
		void Button3Click(object sender, EventArgs e)
		{
			int v = getTextBox();
			label1.Top -= v;
			label1.Height += v;
			if(label1.Top <= 0){
				label1.Height += label1.Top;
				label1.Top = 0;
				button3.Enabled=false;
			}
			label1.Text="Label de "+ label1.Width +" pixeles de ancho y "+ label1.Height +" pixeles de alto.";
		}
		void Button4Click(object sender, EventArgs e)
		{
			int v = getTextBox();
			label1.Width += v;
			if((label1.Left + label1.Width) >= panel1.Width){
				label1.Width = panel1.Width - label1.Left;
				button4.Enabled=false;
			}
			label1.Text="Label de "+ label1.Width +" pixeles de ancho y "+ label1.Height +" pixeles de alto.";
		}
		void Label1DoubleClick(object sender, EventArgs e)
		{
			label1.Top=panel1.Height / 2 - 25;
			label1.Left=panel1.Width / 2 - 75;
			label1.Width=150;
			label1.Height=50;
			label1.Text="Label de "+ label1.Width +" pixeles de ancho y "+ label1.Height +" pixeles de alto.";
			button1.Enabled=true;
			button2.Enabled=true;
			button3.Enabled=true;
			button4.Enabled=true;
		}
		int getTextBox(){
			int r;
			if(int.TryParse(textBox1.Text,out r))
				return r;
			else{
				textBox1.Text = "10";
				// mostras aviso
				MessageBox.Show("Paso seteado a 10.","Paso invalido",MessageBoxButtons.OK);
				return 0;
			}
		}
		void MainFormResizeEnd(object sender, EventArgs e)
		{
			if(label1.Left <= 0){
				label1.Width += label1.Left;
				label1.Left = 0;
				button1.Enabled=false;
			}
			if((label1.Top + label1.Height) >= panel1.Height){
				label1.Height = panel1.Height - label1.Top;
				button2.Enabled=false;
			}
			if(label1.Top <= 0){
				label1.Height += label1.Top;
				label1.Top = 0;
				button3.Enabled=false;
			}
			if((label1.Left + label1.Width) >= panel1.Width){
				label1.Width = panel1.Width - label1.Left;
				button4.Enabled=false;
			}
		}
	}
}
