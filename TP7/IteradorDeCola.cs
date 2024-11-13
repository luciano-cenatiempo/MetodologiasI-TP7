/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 24/10/2024
 * Hora: 10:33
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of IteradorDeCola.
	/// </summary>
	public class IteradorDeCola : Iterador
	{
		// Objeto iterado + indice
		private Cola cola;
		private int indice;
		
		public IteradorDeCola(Cola cola)
		{
			this.cola = cola;
			primero();
		}

		#region Iterador implementation

		public void primero()
		{
			this.indice = 0;
		}

		public void siguiente()
		{
			this.indice++ ;
		}

		public bool fin()
		{
			return this.indice >= cola.cuantos();
		}

		public Comparable actual()
		{
			return cola.getElementos()[indice];
		}

		#endregion
	}
}
