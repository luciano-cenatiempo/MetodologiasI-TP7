/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 24/10/2024
 * Hora: 10:24
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of IteradorDePila.
	/// </summary>
	public class IteradorDePila : Iterador
	{
		// se tiene como argumento el objeto iterable y el indice
		private Pila pila;
		private int indice;
		
		public IteradorDePila(Pila p)
		{
			this.pila = p;
			primero(); // se pone el indice en el primer elemento cuando se construye
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
			return this.indice >= pila.cuantos();
		}

		public Comparable actual()
		{
			return pila.getElementos()[indice];
		}

		#endregion
	}
}
