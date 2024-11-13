/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 9/10/2024
 * Hora: 10:20
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of IEstrategiaComparacion.
	/// </summary>
	public interface IEstrategiaComparacion
	{
		bool sosMayor(IAlumno a1, IAlumno a2);
		bool sosMenor(IAlumno a1, IAlumno a2);
		bool sosIgual(IAlumno a1, IAlumno a2);
		
	}
}
