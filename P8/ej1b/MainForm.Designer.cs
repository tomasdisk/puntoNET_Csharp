/*
 * Created by SharpDevelop.
 * User: tomm
 * Date: 11/12/2017
 * Time: 03:47 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ej1b
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.MinimumSize = new System.Drawing.Size(336, 252);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(336, 254);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.label1.Location = new System.Drawing.Point(89, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "Label de 150 pixeles de ancho y 50 pixeles de alto.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.DoubleClick += new System.EventHandler(this.Label1DoubleClick);
			// 
			// panel2
			// 
			this.panel2.AutoSize = true;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.button4);
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 254);
			this.panel2.MaximumSize = new System.Drawing.Size(0, 48);
			this.panel2.MinimumSize = new System.Drawing.Size(336, 48);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(336, 48);
			this.panel2.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(228, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Paso";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(156, 3);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(49, 41);
			this.button4.TabIndex = 4;
			this.button4.Text = "der";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(105, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(45, 41);
			this.button3.TabIndex = 3;
			this.button3.Text = "arriba";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(54, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(45, 41);
			this.button2.TabIndex = 2;
			this.button2.Text = "abajo";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(45, 41);
			this.button1.TabIndex = 1;
			this.button1.Text = "izq";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(265, 13);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(66, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "10";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(336, 302);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.MinimumSize = new System.Drawing.Size(352, 341);
			this.Name = "MainForm";
			this.Text = "ejercicio1";
			this.ResizeEnd += new System.EventHandler(this.MainFormResizeEnd);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
