/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 4/11/2024
 * Hora: 11:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of AlumnoMuyEstudioso.
	/// </summary>
	public class AlumnoMuyEstudioso : Alumno, IAlumno
	{
		public AlumnoMuyEstudioso() : base() {
			
		}
		public AlumnoMuyEstudioso(string n, int d, int l, int p ): base(n, d, l, p )
		{
		}
		
		public override int responderPregunta(int pregunta)
		{
			return (pregunta % 3);
		}
		
	}
}
