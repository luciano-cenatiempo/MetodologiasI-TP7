/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 8/11/2024
 * Hora: 00:35
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of Ordenable.
	/// </summary>
	public interface Ordenable
	{
		void setOrdenInicio(OrdenEnAula1 orden);
		void setOrdenLlegaAlumno(OrdenEnAula2 orden);
		void setOrdenAulaLlena(OrdenEnAula1 orden);
	}
}
