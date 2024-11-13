/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 8/11/2024
 * Hora: 12:15
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
namespace TP6
{
	/// <summary>
	/// Description of AlumnoCompuesto.
	/// </summary>
	public class AlumnoCompuesto : IAlumno
	{
		private List<IAlumno> hijos;
		public AlumnoCompuesto()
		{
			this.hijos = new List<IAlumno>();
		}
		
		public void agregarAlumno(IAlumno alumno){
			this.hijos.Add(alumno);
		}

		#region IAlumno implementation

		public string getNombre()
		{
			string nombre ="";
			foreach( var hijo in hijos){
				nombre += "\n"+hijo.getNombre();
			}
			
			return nombre;
		}

		public void setNombre(string nombre)
		{
			throw new NotImplementedException();
		}

		public int getLegajo()
		{
			throw new NotImplementedException();
		}

		public int getPromedio()
		{
			int sumaPromedio = 0;
			foreach( var hijo in hijos){
				sumaPromedio += hijo.getPromedio();
			}
			
			if(hijos.Count > 0){
				return sumaPromedio / hijos.Count;
			}
			
			return 0;
		}

		public int getDni()
		{
			throw new NotImplementedException();
		}

		public void setCalificacion(int calificacion)
		{
			foreach (var hijo in hijos) {
				hijo.setCalificacion(calificacion);
			}
		}

		public int getCalificacion()
		{
			throw new NotImplementedException();
		}
		

		public int responderPregunta(int pregunta)
		{
			int max = 0;
			int cantRes1 = 0;
			int cantRes2 = 0;
			int cantRes3 = 0;
			int cantResMax = 0;
			foreach( var hijo in hijos){
				int res = hijo.responderPregunta(pregunta);
				switch (res) {
						case 1: {
							cantRes1++;
							if(cantRes1 > cantResMax){
								cantResMax = cantRes1;
								max = res;
							};break;
						}
						case 2: {
							cantRes2++;
							if(cantRes2 > cantResMax){
								cantResMax = cantRes2;
								max = res;
							};break;
						}
						case 3: {
							cantRes3++;
							if(cantRes3 > cantResMax){
								cantResMax = cantRes3;
								max = res;
							};break;
						}
				}
			}
			
			return max;
			
		}

		public string mostrarCalificacion()
		{
			string calificacion = "";
			
			foreach (var hijo in hijos) {
				calificacion += "\n" + hijo.mostrarCalificacion();
			}
			return calificacion;
		}

		#endregion

		#region Comparable implementation

		public bool sosIgual(Comparable com)
		{
			foreach (var hijo in hijos) {
				if(hijo.sosIgual((IAlumno)com)){
					return true;
				}
			}
			
			return false;
		}

		public bool sosMenor(Comparable com)
		{
			foreach (var hijo in hijos) {
				if(!hijo.sosMenor((IAlumno)com)){
					return false;
				}
			}
			return true;
		}

		public bool sosMayor(Comparable com)
		{
			foreach (var hijo in hijos) {
				if(!hijo.sosMayor((IAlumno)com)){
					return false;
				}
			}
			return true;
		}

		#endregion
	}
}
