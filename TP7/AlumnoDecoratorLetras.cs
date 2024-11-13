/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 4/11/2024
 * Hora: 15:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of AlumnoDecoratorLetras.
	/// </summary>
	public class AlumnoDecoratorLetras: AlumnoDecorator
	{
		public AlumnoDecoratorLetras(IAlumno alumno) : base(alumno)
		{
		}
		
		public override string mostrarCalificacion()
		{
			return base.mostrarCalificacion() + this.getNotaConLetras();
		}
		
		public string getNotaConLetras(){
			switch (getCalificacion()) {
					case 0: return (" (CERO)");break;
					case 1: return (" (UNO)");break;
					case 2: return (" (DOS)");break;
					case 3: return (" (TRES)");break;
					case 4: return (" (CUATRO)");break;
					case 5: return (" (CINCO)");break;
					case 6: return (" (SEIS)");break;
					case 7: return (" (SIETE)");break;
					case 8: return (" (OCHO)");break;
					case 9: return (" (NUEVE)");break;
					case 10: return (" (DIEZ)");break;
					default: return(" (CERO)"); break;
					
			}
		}
	}
}
