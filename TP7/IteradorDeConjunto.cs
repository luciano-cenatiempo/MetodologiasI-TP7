/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 24/10/2024
 * Hora: 10:48
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of IteradorDeConjunto.
	/// </summary>
	public class IteradorDeConjunto : Iterador
	{
		// objeto iterable + indice
		private Conjunto conjunto; 
		private int indice;
		
		public IteradorDeConjunto(Conjunto conjunto)
		{
			this.conjunto = conjunto;
			primero();
		}

		
		#region Iterador implementation

		public void primero()
		{
			this.indice = 0;
		}

		public void siguiente()
		{
			this.indice++;
		}

		public bool fin()
		{
			return this.indice >= conjunto.cuantos();
		}

		public Comparable actual()
		{
			return this.conjunto.getElementos()[indice];
		}

		#endregion
	}
}
