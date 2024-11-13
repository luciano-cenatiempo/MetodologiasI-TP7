/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 8/11/2024
 * Hora: 00:28
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of OrdenInicio.
	/// </summary>
	public class OrdenInicio : OrdenEnAula1
	{
		private Aula aula;
		public OrdenInicio(Aula aula)
		{
			this.aula = aula;
		}

		#region OrdenEnAula1 implementation

		public void ejecutar()
		{
			aula.comenzar();
		}

		#endregion
	}
}
