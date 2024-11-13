/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 29/10/2024
 * Hora: 14:25
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of FabricaDeProfesores
	/// </summary>
	public class FabricaDeProfesores : FabricaDeComparables
	{
		public FabricaDeProfesores()
		{
		}
		
		public  override Comparable crearAleatorio(){
			return new Profesor( m.stringAleatorio(5),
			                  m.numeroAleatorio(1000000),
			                  m.numeroAleatorio(9999));
			                  
		}
		
		public  override Comparable crearPorTeclado(){
			Profesor prof = new Profesor();
			Console.WriteLine("Nombre:");
			prof.setNombre( m.stringPorTeclado());
			Console.WriteLine("DNI:");
			prof.setDni(m.numeroPorTeclado());
			Console.WriteLine("Antiguedad:");
			prof.setAntiguedad(m.numeroPorTeclado());
			
			return prof;
		}
		
		public override Comparable crearPorArchivo()
		{
			return new Profesor( m.stringDesdeArchivo(5),
			                    (int)(m.numeroDesdeArchivo(1000000)),
			                    (int)(m.numeroDesdeArchivo(9999)));
		}
	}
}
