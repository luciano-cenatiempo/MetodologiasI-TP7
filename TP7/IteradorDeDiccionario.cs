/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 24/10/2024
 * Hora: 10:52
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of IteradorDeDiccionario.
	/// </summary>
	public class IteradorDeDiccionario : Iterador
	{
		// Objeto iterable + indice
		private Diccionario diccionario;
		private int indice;
		
		public IteradorDeDiccionario(Diccionario diccionario)
		{
			this.diccionario = diccionario;
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
			return this.indice >= diccionario.cuantos();
		}

		// acá tengo mis dudas, no se sabía si crear otra interfaz iteradorDiccionario                  --------------------- CONSULTA
		// que devuelva una ClaveValor o si devolver valores. Lo hice devolviendo valores 
		// para aprovechar la interfaz creada.
		public Comparable actual()
		{
			return this.diccionario.getValores()[indice];
		}

		#endregion
	}
}
