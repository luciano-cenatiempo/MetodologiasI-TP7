/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 23/10/2024
 * Hora: 19:39
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of ClaveValor.
	/// </summary>
	public class ClaveValor
	{	
		private Comparable clave;
		private Comparable valor;
		public ClaveValor()
		{
			
		}
		
		public ClaveValor(Comparable clave, Comparable valor){
			this.clave = clave;
			this.valor = valor;
		}
		
		public Comparable getClave(){
			return this.clave;
		}
		
		public void setClave(Comparable clave){
			this.clave = clave;
		}
		
		public Comparable getValor(){
			return this.valor;
		}
		
		public void setValor(Comparable valor){
			this.valor = valor;
		}
	}
}
