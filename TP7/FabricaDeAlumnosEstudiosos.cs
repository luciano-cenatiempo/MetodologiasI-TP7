/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 4/11/2024
 * Hora: 12:57
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of FabricaDeAlumnosEstudiosos.
	/// </summary>
	public class FabricaDeAlumnosEstudiosos : FabricaDeComparables
	{
		public FabricaDeAlumnosEstudiosos()
		{
		}
		
		public override Comparable crearAleatorio(){
			return new AlumnoMuyEstudioso( m.stringAleatorio(5),
			                  				m.numeroAleatorio(1000000),
			                  				m.numeroAleatorio(9999),
			                  				m.numeroAleatorio(11));
			                  
		}
		
		public  override Comparable crearPorTeclado(){
			AlumnoMuyEstudioso alu = new AlumnoMuyEstudioso();
			Console.WriteLine("Nombre:");
			alu.setNombre( m.stringPorTeclado());
			Console.WriteLine("DNI:");
			alu.setDni(m.numeroPorTeclado());
			Console.WriteLine("Legajo:");
			alu.setLegajo(m.numeroPorTeclado());
			Console.WriteLine("Promedio:");
			alu.setPromedio(m.numeroPorTeclado());
			
			return alu;
		}
		
		public override Comparable crearPorArchivo()
		{
			return new AlumnoMuyEstudioso( m.stringDesdeArchivo(5),
			                              (int)(m.numeroDesdeArchivo(1000000)),
			                              (int)(m.numeroDesdeArchivo(9999)),
			                  				(int)(m.numeroDesdeArchivo(11)));
		}
	}
}
