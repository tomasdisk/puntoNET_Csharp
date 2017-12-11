/*
 * Created by SharpDevelop.
 * User: tomm
 * Date: 11/12/2017
 * Time: 11:22 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace ej2b
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int h=0,m=0,s=0;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			label4.Text = String.Format("{0:00}:{1:00}:{2:00}",h,m,s);
			comboBox1.Items.AddRange(Enumerable.Range(1, 100).Select(i => (object) i).ToArray());
			comboBox1.SelectedIndex = 9;
			label1.Top = panel2.Height / 2 - label1.Height / 2;
			label1.Left = panel2.Width / 2 - label1.Width / 2;
			draw("info");
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			s++;
			if(s == 60){
				s = 0;
				m++;
				if(m == 60){
					m = 0;
					h++;
					if(h == 99){
						h = 0;
					}
				}
			}
			label4.Text = String.Format("{0:00}:{1:00}:{2:00}",h,m,s);
		}
		void CheckBox1CheckStateChanged(object sender, EventArgs e)
		{
			draw("check");
		}
		void Button1Click(object sender, EventArgs e)
		{
			draw("up");
		}
		void Button3Click(object sender, EventArgs e)
		{
			draw("left");
		}
		void Button2Click(object sender, EventArgs e)
		{
			draw("down");
		}
		void Button4Click(object sender, EventArgs e)
		{
			draw("rigth");
		}
		void Label1Click(object sender, EventArgs e)
		{
			//color
			
		}
		void NumericUpDown1ValueChanged(object sender, EventArgs e)
		{
			draw("size");
		}
				
		void draw(string op)
		{
			//redibujar con propiedades actuales
			if (op == "up")
			{
				label1.Top -= (int)comboBox1.SelectedItem;
				label1.Text = "Arriba";
			}
			if (op == "left")
			{
				label1.Left -= (int)comboBox1.SelectedItem;
				label1.Text = "Izquierda";
			}
			if (op == "down")
			{
				label1.Top += (int)comboBox1.SelectedItem;
				label1.Text = "Abajo";
			}
			if (op == "rigth")
			{
				label1.Left += (int)comboBox1.SelectedItem;
				label1.Text = "Derecha";
			}
			if (op == "size")
			{
				label1.Font = new Font(label1.Font.FontFamily, (float)numericUpDown1.Value);;
			}
			if (checkBox1.Checked)
			{
				if((label1.Left + label1.Width) >= panel2.Width){
					label1.Left = panel2.Width - label1.Width;
				}
				if((label1.Top + label1.Height) >= panel2.Height){
					label1.Top = panel2.Height - label1.Height;
				}
				if(label1.Top <= 0){
					label1.Top = 0;
				}
				if(label1.Left <= 0){
					label1.Left = 0;

				}
			}
			
			//cambiar informacion
			label2.Text = "Left="+ label1.Left +", Top="+ label1.Top;
			label3.Text = "Width="+ label1.Width +", Height="+ label1.Height;
		}
	}
}
