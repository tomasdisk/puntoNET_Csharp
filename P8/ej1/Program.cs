/*
 * Created by SharpDevelop.
 * User: tomm
 * Date: 10/12/2017
 * Time: 07:28 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ej1
{
	delegate void NotificacionEventHandler(object sender, EventArgs e);
	delegate void TicEventHandler(object sender, TicEventArgs e);
	class Program
	{
		static int cont=0;
		static Clock reloj=new Clock();
		public static void Main(string[] args)
		{
			/* ejercicio 1 */
			{
				Objeto o=new Objeto();
				o.OnFinTrabajo += new NotificacionEventHandler(F);
				o.OnFinTrabajo += new NotificacionEventHandler(G);
				o.Trabajar();
			}
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);
            
            /* ejercicio 2 */
			{
				reloj.Tic+=new TicEventHandler(Tic);
				reloj.Tic+=new TicEventHandler(Tic);
			}
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* fin */
            System.Console.Write("bye..");
		}
		// metodos del ej1
		private static void F(object sender, EventArgs e){
			Console.WriteLine("ejecutando F");
		}
		private static void G(object sender, EventArgs e){
			Console.WriteLine("ejecutando G");
		}
		// metodos del ej2
		private static void Tic(object sender, TicEventArgs e){
			Console.WriteLine(e.Hora);
			cont++;
			if(cont==10) reloj.Detener();
			cont = 0;
		}
	}
	// clase del ej1
	class Objeto{
		private int cont=0;
		private NotificacionEventHandler onFinTrabajo;
		public event NotificacionEventHandler OnFinTrabajo{
			add {
				if(cont==0){
					onFinTrabajo += value; cont++;
				}
			}
			remove{
				if(cont>0){
					onFinTrabajo -= value; cont--;
				}
			}
		}
		public void Trabajar(){
			Console.WriteLine("Objeto trabajando");
			onFinTrabajo(this, new EventArgs());
		}
	}
	// clase del ej2
	class TicEventArgs:EventArgs
	{
		private DateTime hora;
		public DateTime Hora{
			get{return hora;}
			set{hora=value;}
		}
		public TicEventArgs(DateTime hora){
			this.hora=hora;
		}
	}
	class Clock{
		private bool detener;
		private int cont = 0;
		private TicEventHandler tic;
		public event TicEventHandler Tic{
			add{if(cont < 4){tic += value; cont++; this.run();}}
			remove{tic -= value; cont--;}
		}
		private void run(){
			DateTime hora=DateTime.Parse("1/1/2000");
			DateTime horaAux=DateTime.Now;
			detener=false;
			while (!detener){
				if(hora.Second != horaAux.Second){
					hora=horaAux;
					if(tic!=null) tic(this,new TicEventArgs(hora));
					else {
						Console.WriteLine("Sin event handler");
						break;
					}
				}
				horaAux=DateTime.Now;
			}
		}
		public void Detener(){
			detener=true;
			tic = null;
			this.run();
		}
	}
}