/*
 * Created by SharpDevelop.
 * User: tomm
 * Date: 11/12/2017
 * Time: 03:16 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ej3
{
	delegate void PrecioCambiadoEventHandler(object sender, PrecioCambiadoEventArgs e);
	class Program
	{
		public static void Main(string[] args) {
			/* ejercicio 3 */
			Articulo a=new Articulo();
			a.PrecioCambiado += new PrecioCambiadoEventHandler(precioCambiado);
			a.Codigo = 1;
			a.Precio = 10;
			a.Precio = 12;
			a.Precio = 12;
			a.Precio = 14;
			System.Console.WriteLine("Presione una tecla para continuar");
			Console.ReadKey(true);
		}
		public static void precioCambiado(object sender, PrecioCambiadoEventArgs e){
			string texto="Artículo {0} valía {1} y ahora vale {2}";
			Console.WriteLine(texto,e.Codigo,e.PrecioAnterior,e.PrecioNuevo);
		}
	}
	class PrecioCambiadoEventArgs
	{
		public int Codigo{get;set;}
		public double PrecioAnterior{get;set;}
		public double PrecioNuevo{get;set;}
	}
	class Articulo
	{
		public int Codigo{get;set;}
		private double precio;
		public double Precio{
			get{return precio;}
			set{
				if(!precio.Equals(value)){
					precioCambiado(this, new PrecioCambiadoEventArgs(){Codigo=Codigo, PrecioNuevo=value,PrecioAnterior=precio}); 
					precio=value;
				}
			}
		}
		private PrecioCambiadoEventHandler precioCambiado;
		public event PrecioCambiadoEventHandler PrecioCambiado{
			add{precioCambiado+=value;}
			remove{precioCambiado-=value;}
		}
	}
}