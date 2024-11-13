/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 9/10/2024
 * Hora: 10:48
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of PorPromedio.
	/// </summary>
	public class PorPromedio : IEstrategiaComparacion
	{
		public PorPromedio()
		{
		}
		
		public bool sosIgual(IAlumno a1, IAlumno a2){
			return a1.getPromedio() == a2.getPromedio();
		}
		
		public bool sosMayor(IAlumno a1, IAlumno a2){
			return a1.getPromedio() > a2.getPromedio();
		}
		
		public bool sosMenor(IAlumno a1, IAlumno a2){
			return a1.getPromedio() < a2.getPromedio();
		}
	}
}
