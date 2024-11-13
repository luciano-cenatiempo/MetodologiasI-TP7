/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 29/10/2024
 * Hora: 10:32
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of FabricaDeAlumnos.
	/// </summary>
	public class FabricaDeAlumnos : FabricaDeComparables
	{
		public FabricaDeAlumnos()
		{
		}
		
		public override Comparable crearAleatorio(){
			return new Alumno( m.stringAleatorio(5),
			                  m.numeroAleatorio(1000000),
			                  m.numeroAleatorio(9999),
			                  m.numeroAleatorio(10));
			                  
		}
		
		public  override Comparable crearPorTeclado(){
			Alumno alu = new Alumno();
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
		
		public override Comparable crearPorArchivo(){
			return new Alumno( m.stringDesdeArchivo(5),
								(int)(m.numeroDesdeArchivo(1000000)),
			                    (int)(m.numeroDesdeArchivo(9999)),
			                  	(int)(m.numeroDesdeArchivo(11)));
			                  
		}
	}
}
