/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 25/10/2024
 * Hora: 10:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of FabricaDeComparables.
	/// </summary>
	public abstract class FabricaDeComparables
	{
		public const int ALUMNO = 1;
		public const int NUMERO = 2;
		public const int PROFESOR = 3;
		public const int ALUMNO_ESTUDIOSO = 4;
		public const int ALUMNO_COMPUESTO = 5;
		
		
//		protected GeneradorDeDatosAleatorios aleatorio = new GeneradorDeDatosAleatorios();
//		protected LectorDeDatos lector = new LectorDeDatos();
//		
		
		
		public abstract Comparable crearAleatorio();
		public abstract Comparable crearPorTeclado();
		public abstract Comparable crearPorArchivo();
		
		protected Manejador m;
		
		public FabricaDeComparables(){
			m = GeneradorDeDatosAleatorios.getInstance(null);
			m = new LectorDeDatos(m);
			m = LectorDeArchivos.getInstance(m);
		}
		public static Comparable crearAleatorio(int opcion){
			// Aplicacion del patron Chain of Responsability
			
			
			FabricaDeComparables fabrica = null;
			switch(opcion){
					case 1: fabrica = new FabricaDeAlumnos();break;
					case 2: fabrica = new FabricaDeNumeros();break;
					case 3: fabrica = new FabricaDeProfesores();break;
					case 4: fabrica = new FabricaDeAlumnosEstudiosos();break;
					case 5: fabrica = new FabricaAlumnoCompuesto();break;
					
			}
			
			return fabrica.crearAleatorio();
		}
		
		public static Comparable crearPorTeclado(int opcion){
			FabricaDeComparables fabrica = null;
			switch(opcion){
					case 1: fabrica = new FabricaDeAlumnos();break;
					case 2: fabrica = new FabricaDeNumeros();break;	
					case 3: fabrica = new FabricaDeProfesores();break;
					case 4: fabrica = new FabricaDeAlumnosEstudiosos();break;
					case 5: fabrica = new FabricaAlumnoCompuesto();break;
					
			}
			
			return fabrica.crearPorTeclado();
		}
		
		
		public static Comparable crearPorArchivo(int opcion){
			FabricaDeComparables fabrica = null;
			switch(opcion){
					case 1: fabrica = new FabricaDeAlumnos();break;
					case 2: fabrica = new FabricaDeNumeros();break;	
					case 3: fabrica = new FabricaDeProfesores();break;
					case 4: fabrica = new FabricaDeAlumnosEstudiosos();break;
					case 5: fabrica = new FabricaAlumnoCompuesto();break;
					
			}
			
			return fabrica.crearPorArchivo();
		}
		
	}
}
