/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 4/11/2024
 * Hora: 15:33
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of AlumnoDecoratorLegajo.
	/// </summary>
	public class AlumnoDecoratorLegajo : AlumnoDecorator
	{
		public AlumnoDecoratorLegajo(IAlumno alumno):base(alumno)
		{
		}
		
		 public override string mostrarCalificacion()
        {
		 	string texto = this.getNombre() + (" (") + this.getLegajo() + ")";
		 	return base.mostrarCalificacion().Replace(getNombre(),texto);
        }
	}
}
