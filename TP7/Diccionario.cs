/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 23/10/2024
 * Hora: 19:38
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace TP6
{
	/// <summary>
	/// Description of Diccionario.
	/// </summary>
	public class Diccionario : Coleccionable, Iterable, Ordenable
	{
		private List<ClaveValor> elementos;
		private OrdenEnAula1 ordenInicio = null;
		private OrdenEnAula1 ordenFin = null;
		private OrdenEnAula2 ordenAlumno = null;
		
		// implemento el conjunto para almacenar las claves y que no se repitan
		private Conjunto conjuntoClaves;
		
		public Diccionario()
		{
			this.elementos = new List<ClaveValor>();
			this.conjuntoClaves = new Conjunto();
			
		}
		
		// este metodo lo armé para que el iterador devuelva los valores 
		public List<Comparable> getValores(){
			List<Comparable> valores = new List<Comparable>();
			
			foreach(ClaveValor elemento in elementos){
				valores.Add(elemento.getValor());
			}
			
			return valores;
		}
		
		
		public void agregar(ClaveValor claveValor){
			if(!conjuntoClaves.pertenece(claveValor.getClave())){
				// agrego la llave al conjunto
				conjuntoClaves.agregar(claveValor.getClave());
				
				// Agrego la claveValor al diccionario
				elementos.Add(claveValor);
			}
		}
		
		public Comparable valorDe(Comparable clave){
			foreach(ClaveValor elemento in elementos){
				if(clave.sosIgual(elemento.getClave())){
					return elemento.getValor();
				}
			}
			
			return null;
		}

		#region Coleccionable implementation

		public int cuantos()
		{
			return elementos.Count;
		}

		public Comparable minimo()
		{
			Comparable min = elementos[0].getValor();
			for (int i = 1; i < elementos.Count; i++) {
				if (elementos[i].getValor().sosMenor(min)) {
					min = elementos[i].getValor();
				}
			}
			return min;
		}

		public Comparable maximo()
		{
			Comparable max = elementos[0].getValor();
			for (int i = 1; i < elementos.Count; i++) {
				if (elementos[i].getValor().sosMayor(max)) {
					max = elementos[i].getValor();
				}
			}
			return max;
		}

		public void agregar(Comparable com)
		{
			
			// AGREGAR DE EJERCICIO 5
			// no entendí como hay que plantearlo          ---------------------------------- CONSULTA
			if (elementos.Count == 1) {
				if (ordenInicio != null) {
					ordenInicio.ejecutar();
					
				}
			}
			if (ordenAlumno != null) {
				ordenAlumno.ejecutar(com);
			}
			if (elementos.Count == 40) {
				if (ordenFin != null) {
					ordenFin.ejecutar();
					if (ordenAlumno != null) {
						ordenAlumno.ejecutar(com);
					}
				}
			}
		}

		public bool contiene(Comparable com)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region Iterable implementation

		// iterador = new Iterador
		public Iterador crearIterador()
		{
			return new IteradorDeDiccionario(this);
		}

		#endregion
		
		
		#region Ordenable implementation

		public void setOrdenInicio(OrdenEnAula1 orden)
		{
			this.ordenInicio = orden;
		}

		public void setOrdenLlegaAlumno(OrdenEnAula2 orden)
		{
			this.ordenAlumno = orden;
		}

		public void setOrdenAulaLlena(OrdenEnAula1 orden)
		{
			this.ordenFin = orden;
		}

		#endregion
	}
	
	// continuar con el ejercicio 6
}
