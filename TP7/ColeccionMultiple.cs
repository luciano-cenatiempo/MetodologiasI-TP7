/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 13/9/2024
 * Hora: 12:14
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of ColeccionMultiple.
	/// </summary>
	public class ColeccionMultiple : Coleccionable
	{
		private Pila pila;
		private Cola cola;
		public ColeccionMultiple()
		{
			pila = new Pila();
			cola = new Cola();
		}
		
		public ColeccionMultiple(Pila p, Cola c)
		{
			pila = p;
			cola = c;
		}
		
		public int cuantos(){
			return (pila.cuantos() + cola.cuantos());
		}
		public Comparable minimo(){
			
			if(pila.minimo().sosMenor( cola.minimo())){
				return pila.minimo();
			}
			
			return cola.minimo();
			
		}
		public Comparable maximo(){
			if (pila.maximo().sosMayor(cola.maximo())) {
				return pila.maximo();
			}
			
			return cola.maximo();
		}
		public void agregar(Comparable com){
			
		}
		public bool contiene(Comparable com){
			
			return (pila.contiene(com) || cola.contiene(com));	
			
		}
	}
}
