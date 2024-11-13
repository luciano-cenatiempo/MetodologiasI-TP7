/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 4/11/2024
 * Hora: 15:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of IAlumno.
	/// </summary>
	public interface IAlumno : Comparable
	{
		string getNombre();
		void setNombre(string nombre);
		
		int getLegajo();

        int getPromedio();
        
        int getDni();

        void setCalificacion(int calificacion);

        int getCalificacion();

        int responderPregunta(int pregunta);

        string mostrarCalificacion();

    }
		
	
}
