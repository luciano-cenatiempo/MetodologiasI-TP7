/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 9/10/2024
 * Hora: 10:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of PorDni.
	/// </summary>
	public class PorDni : IEstrategiaComparacion
	{
		public PorDni()
		{
		}
		
		public bool sosIgual(IAlumno a1, IAlumno a2){
			return a1.getDni() == a2.getDni();
		}
		
		public bool sosMayor(IAlumno a1, IAlumno a2){
			return a1.getDni() > a2.getDni();
		}
		
		public bool sosMenor(IAlumno a1, IAlumno a2){
			return a1.getDni() < a2.getDni();
		}
	}
}
