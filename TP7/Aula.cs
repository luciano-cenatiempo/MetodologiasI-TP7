/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 8/11/2024
 * Hora: 00:23
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of Aula.
	public class Aula
	{
		/// </summary>
		Teacher teacher;
		
		public Aula()
		{
		}
		
		public void comenzar(){
			this.teacher = new Teacher();
			Console.WriteLine("se instanció el teacher");
		}
		
		public void nuevoAlumno(IAlumno alumno){
			teacher.goToClass(new AdaptadorAlumno(alumno));
		}
		
		public void claseLista(){
			teacher.teachingAClass();
		}
	}
}
