/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 8/11/2024
 * Hora: 15:17
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of FabricaAlumnoCompuesto.
	/// </summary>
	public class FabricaAlumnoCompuesto : FabricaDeComparables
	{
		public FabricaAlumnoCompuesto()
		{
		}

		#region implemented abstract members of FabricaDeComparables

		public override Comparable crearAleatorio()
		{
			AlumnoCompuesto aluCompuesto = new AlumnoCompuesto();
			
			for(int i = 0; i<5 ;i++){
				IAlumno alu = new AlumnoProxy("Compuesto "+ i,FabricaDeComparables.ALUMNO);
				alu = new AlumnoDecoratorLegajo(alu);
				alu = new AlumnoDecoratorLetras(alu);
				alu = new AlumnoDecoratorTipoNota(alu);
				alu = new AlumnoDecoratorRecuadro(alu);
				
				aluCompuesto.agregarAlumno(alu);
			}
			
			return aluCompuesto;
			
		}

		public override Comparable crearPorTeclado()
		{
			throw new NotImplementedException();
		}
		
		public override Comparable crearPorArchivo()
		{
			AlumnoCompuesto aluCompuesto = new AlumnoCompuesto();
			
			for(int i = 0; i<5 ;i++){
				IAlumno alu = new AlumnoProxy("Compuesto "+ i,FabricaDeComparables.ALUMNO);
				alu = new AlumnoDecoratorLegajo(alu);
				alu = new AlumnoDecoratorLetras(alu);
				alu = new AlumnoDecoratorTipoNota(alu);
				alu = new AlumnoDecoratorRecuadro(alu);
				
				aluCompuesto.agregarAlumno(alu);
			}
			
			return aluCompuesto;
			
		}

		#endregion
	}
}
