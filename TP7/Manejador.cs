/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 12/11/2024
 * Hora: 23:45
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of Manejador.
	/// </summary>
	public class Manejador
	{
		protected Manejador sucesor = null;
		
		public Manejador(Manejador m)
		{
			this.sucesor = m;
		}
		
		public virtual string stringAleatorio(int cant){
			if (sucesor != null) {
				return sucesor.stringAleatorio(cant);
			}
			return "";
		}
		
		public virtual int numeroAleatorio(int max){
			if (sucesor != null) {
				return sucesor.numeroAleatorio(max);
			}
			return 0;
		}
		
		public virtual int numeroPorTeclado(){
			if (sucesor != null) {
				return sucesor.numeroPorTeclado();
			}
			return 0;
		}
		
		public virtual string stringPorTeclado(){
			if (sucesor != null) {
				return sucesor.stringPorTeclado();
			}
			return "";
		}
		
		public virtual double numeroDesdeArchivo(double max){
			if (sucesor != null) {
				return sucesor.numeroDesdeArchivo(max);
			}
			return 0;
		}
		
		public virtual string stringDesdeArchivo(int cant){
			if (sucesor != null) {
				return sucesor.stringDesdeArchivo(cant);
			}
			return "";
		}
	}
}
