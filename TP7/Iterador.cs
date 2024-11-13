/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 24/10/2024
 * Hora: 10:12
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of Iterador.
	/// </summary>
	public interface Iterador
	{
		void primero();
		void siguiente();
		bool fin();
		Comparable actual();// acá el objeto iterado es un comparable
		
	}
}
