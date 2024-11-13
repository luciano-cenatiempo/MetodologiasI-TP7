/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 4/11/2024
 * Hora: 15:52
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of AlumnoDecoratorRecuadro.
	/// </summary>
	public class AlumnoDecoratorRecuadro : AlumnoDecorator
	{
		public AlumnoDecoratorRecuadro(IAlumno alumno): base(alumno)
		{
		}
		
		public override string mostrarCalificacion()
		{
			return califacionRecuadro();
		}
		
		public string califacionRecuadro(){
			string recuadro = "************************************\n" +"*" + base.mostrarCalificacion() +"*\n" + "************************************\n";
			
			return recuadro;
		}
	}
}
