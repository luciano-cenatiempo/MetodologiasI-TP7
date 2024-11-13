/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 4/11/2024
 * Hora: 15:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of AlumnoDecoratorTipoNota.
	/// </summary>
	public class AlumnoDecoratorTipoNota : AlumnoDecorator
	{
		public AlumnoDecoratorTipoNota(IAlumno alumno):base(alumno)
		{
			
		}
		
		 public override string mostrarCalificacion()
        {
            return base.mostrarCalificacion() + this.getTipoNota();
        }

        public string getTipoNota()
        {
            

        	if (this.getCalificacion() < 4){
        		return (" (DESAPROBADO)");
        	} else if (this.getCalificacion() >= 4 && this.getCalificacion() < 7){
                return " (APROBADO)";
        	}else{
                return " (PROMOCIONADO)";
        	}

            
        }
	}
}
