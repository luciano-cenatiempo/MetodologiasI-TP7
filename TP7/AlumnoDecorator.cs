/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 4/11/2024
 * Hora: 15:18
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of AlumnoDecorator.
	/// </summary>
	public abstract class AlumnoDecorator : IAlumno
	{
		IAlumno alumno;
		public AlumnoDecorator(IAlumno alumno)
		{
			this.alumno = alumno;
		}

		#region IAlumno implementation
		public string getNombre(){
			return this.alumno.getNombre();
		}
		public int getDni(){
			return this.alumno.getDni();
		}
		
		public void setNombre(string nombre){
			this.alumno.setNombre(nombre);
		}

		public int getLegajo()
		{
			return this.alumno.getLegajo();
		}

		public int getPromedio()
		{
			return this.alumno.getPromedio();
		}

		public void setCalificacion(int calificacion)
		{
			this.alumno.setCalificacion(calificacion);
		}

		public int getCalificacion()
		{
			return this.alumno.getCalificacion();
		}

		public int responderPregunta(int pregunta)
		{
			return this.alumno.responderPregunta(pregunta);
		}

		public virtual string mostrarCalificacion()
		{
			return this.alumno.mostrarCalificacion();
		}

		#endregion

		public bool sosIgual(Comparable com)
		{
			if(com is AlumnoCompuesto)
				return alumno.sosIgual(com);
			return alumno.sosIgual(((AlumnoDecorator)com).alumno);
		}

		public bool sosMenor(Comparable com)
		{
			if(com is AlumnoCompuesto)
			 	return alumno.sosMenor(com);
				
			return alumno.sosMenor(((AlumnoDecorator)com).alumno);
			
		}

		public bool sosMayor(Comparable com)
		{
			if(com is AlumnoCompuesto)
			 	return alumno.sosMayor(com);
			return alumno.sosMayor(((AlumnoDecorator)com).alumno);
		}
	}
}
