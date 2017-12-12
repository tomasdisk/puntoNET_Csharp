/*
 * Created by SharpDevelop.
 * User: Carlos
 * Date: 11/12/2017
 * Time: 04:43 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ej1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string dir;
		string pic;
		Queue cola;
		Form pantallaCompleta;
		System.Windows.Forms.PictureBox pictureBox2;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			toolStripComboBox1.Items.AddRange(new string[] {
			"Intervalo de presentación: 2 seg.",
			"Intervalo de presentación: 4 seg.",
			"Intervalo de presentación: 6 seg.",
			"Intervalo de presentación: 8 seg.",
			"Intervalo de presentación: 10 seg."});
			toolStripComboBox1.SelectedIndex = 0;
			dir = Directory.GetCurrentDirectory();
			foreach (FileInfo f in new DirectoryInfo(dir).GetFiles())
			{
				if(f.Extension.ToLower() == ".jpeg" || f.Extension.ToLower() == ".jpg" || f.Extension.ToLower() == ".gif" || f.Extension.ToLower() == ".ico" || f.Extension.ToLower() == ".bmp")
				{
					listBox1.Items.Add(f.Name);
				}
			}
			toolStripStatusLabel1.Text = dir;
			//mostar primera iamgen si la hay
			if(listBox1.Items.Count > 0)
			{
				draw(listBox1.Items[0].ToString());
			}
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void AbrirCarpetaToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
				dir = folderBrowserDialog1.SelectedPath;
				DirectoryInfo  d = new DirectoryInfo(dir);
				listBox1.Items.Clear();
				foreach (FileInfo f in d.GetFiles())
				{
					if(f.Extension.ToLower() == ".jpeg" || f.Extension.ToLower() == ".jpg" || f.Extension.ToLower() == ".gif" || f.Extension.ToLower() == ".ico" || f.Extension.ToLower() == ".bmp")
					{
						listBox1.Items.Add(f.Name);
					}
				}
				toolStripStatusLabel1.Text = dir;
				//mostar primera iamgen si la hay
				if(listBox1.Items.Count > 0)
				{
					draw(listBox1.Items[0].ToString());
				}
				else
				{
					draw("none");
				}
			}
		}
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			//cerrar programa
			this.Close();			
		}
		void AjustarALaVentanaToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(ajustarALaVentanaToolStripMenuItem.Checked)
			{
				ajustarALaVentanaToolStripMenuItem.Checked = false;
			}
			else
			{
				ajustarALaVentanaToolStripMenuItem.Checked = true;
			}
			draw(pic);
		}
		void AToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(aToolStripMenuItem.Checked)
			{
				splitContainer1.Panel1Collapsed = true;
				aToolStripMenuItem.Checked = false;
			}
			else
			{
				splitContainer1.Panel1Collapsed = false;
				aToolStripMenuItem.Checked = true;
			}
			draw(pic);
		}
		void PresentaciónToolStripMenuItemClick(object sender, EventArgs e)
		{
			presentaciónToolStripMenuItem.Checked = true;
			//encolar imagenes
			cola = new Queue(listBox1.Items);
			//pantalla completa
			pantallaCompleta = new Form();
			pantallaCompleta.FormBorderStyle = FormBorderStyle.None;
			pantallaCompleta.WindowState = FormWindowState.Maximized;
			//nuevo pictureBox
			pictureBox2 = new System.Windows.Forms.PictureBox();
			pictureBox2.Location = new System.Drawing.Point(0, 0);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.TabIndex = 0;
			pictureBox2.TabStop = false;
			//mostrar
			pantallaCompleta.Controls.Add(pictureBox2);
			pantallaCompleta.Show();
			draw((string)cola.Peek());
			//evento ECS para cerrar pantalla Completa
			pantallaCompleta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			//iniciar timer
			timer1.Interval = toolStripComboBox1.SelectedIndex * 2000 + 2000;
			timer1.Enabled = true;
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			//cambiar a imagen siguiente
			cola.Enqueue(cola.Dequeue());
			draw((string)cola.Peek());
			
		}
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			draw(listBox1.SelectedItem.ToString());
		}
		void MainFormResizeEnd(object sender, EventArgs e)
		{
			draw(pic);
		}
		void draw(string image)
		{
			pic = image;
			if(presentaciónToolStripMenuItem.Checked)
			{
				pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
				pictureBox2.Size = pantallaCompleta.ClientSize;
				if(pic != "none")
				{
					pictureBox2.Image = Image.FromFile(dir + "\\" + pic);
				}
				else
				{
					pictureBox2.Image = null;
				}
			}
			else
			{
				if(ajustarALaVentanaToolStripMenuItem.Checked)
				{
					splitContainer1.Panel2.AutoScroll = false;
					pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
					pictureBox1.Size = splitContainer1.Panel2.ClientSize;
				}
				else
				{
					splitContainer1.Panel2.AutoScroll = true;
	
					pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
				}
			
				if(pic != "none")
				{
					pictureBox1.Image = Image.FromFile(dir + "\\" + pic);
				}
				else
				{
					pictureBox1.Image = null;
				}
			}
		}
		void MainFormKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)27)
			{
				timer1.Enabled = false;
				presentaciónToolStripMenuItem.Checked = false;
				pantallaCompleta.Close();
				draw(pic);
			}
		}
	}
}
