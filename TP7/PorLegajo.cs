/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 9/10/2024
 * Hora: 10:46
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6{
	/// <summary>
	/// Description of PorLegajo.
	/// </summary>
	public class PorLegajo : IEstrategiaComparacion
	{
		public PorLegajo()
		{
		}
		
		public bool sosIgual(IAlumno a1, IAlumno a2){
			return a1.getLegajo() == a2.getLegajo();
		}
		
		public bool sosMayor(IAlumno a1, IAlumno a2){
			return a1.getLegajo() > a2.getLegajo();
		}
		
		public bool sosMenor(IAlumno a1, IAlumno a2){
			return a1.getLegajo() < a2.getLegajo();
		}
		
	}
}
