/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 25/10/2024
 * Hora: 10:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of LectorDeDatos.
	/// </summary>
	public class LectorDeDatos : Manejador
	{
		protected Manejador sucesor;
		public LectorDeDatos(Manejador m):base(m)
		{
			this.sucesor = m;
		}
		
		public override int numeroPorTeclado(){
			
			bool ingresoOk = false;
			int valor = 0;
			while (!ingresoOk) {
				Console.WriteLine("Ingrese un número: ");
				string teclado =  Console.ReadLine();
				
				try {
					valor =  Int32.Parse(teclado);
					ingresoOk = true;
					
					
				} catch (Exception) {
					
					Console.WriteLine("Lo que ingresó no se reconoce como número");
				}
					
				}
				return valor;
			}
		
		public override string stringPorTeclado(){
			Console.WriteLine("Ingrese el texto: ");
				string teclado =  Console.ReadLine();
				return teclado;
		}
	}
}
