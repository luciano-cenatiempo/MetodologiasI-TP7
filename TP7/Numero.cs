/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 3/9/2024
 * Hora: 14:56
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of Numero.
	/// </summary>
	public class Numero : Comparable
	{
		private int valor;
		
		public Numero(){}
		
		public Numero(int v)
		{
			this.valor = v;
		}
		
		public int getValor(){
			return this.valor;
		}
		public void setValor(int valor){
			this.valor = valor;
		}
		
		public bool sosIgual(Comparable com){
			return (this.valor == ((Numero) com).getValor());
		}
		public bool sosMenor(Comparable com){
			return (this.valor < ((Numero) com).getValor());
		}
		public bool sosMayor(Comparable com){
			return (this.valor > ((Numero) com).getValor());
			
		}
		
		public override string ToString(){
			return((string) this.getValor().ToString());
		}
	}
}
