/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 23/10/2024
 * Hora: 19:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace TP6
{
	/// <summary>
	/// Description of Conjunto.
	/// </summary>
	public class Conjunto : Coleccionable, Iterable, Ordenable
	{
		private OrdenEnAula1 ordenInicio = null;
		private OrdenEnAula1 ordenFin = null;
		private OrdenEnAula2 ordenAlumno = null;
		
		private List<Comparable> elementos;
		public Conjunto()
		{
			elementos = new List<Comparable>();
		}
		
		
		public List<Comparable> getElementos(){
			return this.elementos;
		}
		
		public int cuantos()
		{
			return this.elementos.Count;
		}
		public Comparable minimo()
		{
			Comparable min = elementos[0];
			for (int i = 1; i < elementos.Count; i++) {
				if (elementos[i].sosMenor(min)) {
					min = elementos[i];
				}
			}
			return min;
		}
		public Comparable maximo()
		{
			Comparable max = elementos[0];
			for (int i = 1; i < elementos.Count; i++) {
				if (elementos[i].sosMayor(max)) {
					max = elementos[i];
				}
			}
			return max;
		}
		public void agregar(Comparable com)
		{
			if (!pertenece(com)) {
				this.elementos.Add(com);
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
			
		}
		public bool contiene(Comparable com)
		{
			foreach (Comparable el in elementos){
				if (com.sosIgual(el)) {
					return true;
				}
			}
			return false;
		}
		
		// metodo pertenece
		public bool pertenece(Comparable com){
			return contiene(com);
			
		}
		
		
		#region Iterable implementation
		public Iterador crearIterador()
		{
			return new IteradorDeConjunto(this);
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
}
