/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 4/11/2024
 * Hora: 12:17
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of AdaptadorAlumno.
	/// </summary>
	public class AdaptadorAlumno : Student, Comparable
	{	
		protected IAlumno alumno;
		public AdaptadorAlumno(IAlumno alumno)
		{
			this.alumno = alumno;
		}
		
		public IAlumno getAlumno(){
			return alumno;
		}

		#region Student implementation

		public string getName()
		{
			return alumno.getNombre();
		}

		public int yourAnswerIs(int question)
		{
			return alumno.responderPregunta(question);
		}

		public void setScore(int score)
		{
			alumno.setCalificacion(score);
		}

		public string showResult()
		{
			return alumno.mostrarCalificacion();
		}

		public bool equals(Student student)
		{
			if(student is AdaptadorAlumno){
				return sosIgual((AdaptadorAlumno)student);
			}
			return false;
		}

		public bool lessThan(Student student)
		{
			if(student is AdaptadorAlumno){
				return sosMenor((AdaptadorAlumno)student);
			}
			return false;
		}

		public bool greaterThan(Student student)
		{
			if(student is AdaptadorAlumno){
				return sosMayor((AdaptadorAlumno)student);
			}
			return false;
		}

		#endregion

		#region Comparable implementation

		public bool sosIgual(Comparable com)
		{
			if (com is AdaptadorAlumno)
				return this.alumno.sosIgual(((AdaptadorAlumno)com).getAlumno());

            return false;
		}

		public bool sosMenor(Comparable com)
		{
			if (com is AdaptadorAlumno)
                return this.alumno.sosMenor(((AdaptadorAlumno)com).getAlumno());

            return false;
		}

		public bool sosMayor(Comparable com)
		{
			if (com is AdaptadorAlumno)
                return this.alumno.sosMayor(((AdaptadorAlumno)com).getAlumno());

            return false;
		}

		#endregion
	}
}
