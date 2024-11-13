/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 8/11/2024
 * Hora: 00:33
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of OrdenLlegaAlumno.
	/// </summary>
	public class OrdenLlegaAlumno : OrdenEnAula2
	{
		private Aula aula;
		public OrdenLlegaAlumno(Aula aula)
		{
			this.aula = aula;
		}

		#region OrdenEnAula2 implementation

		public void ejecutar(Comparable com)
		{
			aula.nuevoAlumno((IAlumno) com);
		}

		#endregion
	}
}
