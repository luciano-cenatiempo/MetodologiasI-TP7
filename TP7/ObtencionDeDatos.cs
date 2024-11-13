/*
 * Created by Metodologías de Programación I
 * Activity 7. 
 * Chain of responsability and Singleton patterns 
 *
 * Antes de usar este código el alumno deberá agregar a la variable "ruta_archivo" de la clase 
 * "LectorDeArchivos" la ruta correspondiente a su equipo donde haya guardado el archvo con los datos
 * provistos por la cátedra (archivo datos.txt)
 *
 * IMPORTANTE *  
 * El código que está en este archivo SI puede modificarse para resolver la actividad solicitada
 * 
 */

using System;
using System.IO;


namespace TP6
{
	public class LectorDeArchivos : Manejador
	{
		public Manejador sucesor;
		
		// El alumno deberá agregar la ruta correspondiente a su equipo donde haya guardado el archvo con los datos
		private const string ruta_archivo = @"C:\Users\luciano.cenatiempo\Documents\SharpDevelop Projects\TP7\datos.txt";
		// --------------------------------------------------------------------------------------------------------
		
		private StreamReader lector_de_archivos;
		
		private static LectorDeArchivos unicaInstancia = null;
		private LectorDeArchivos(Manejador m):base(m){
			lector_de_archivos = new StreamReader(ruta_archivo);
			this.sucesor = m;
		}
		
		public double numeroDesdeArchivo(double max){
			string linea = lector_de_archivos.ReadLine();
			return Double.Parse(linea.Substring(0, linea.IndexOf('\t'))) * max;
		}
		
		public string stringDesdeArchivo(int cant){
			string linea = lector_de_archivos.ReadLine();
			linea = linea.Substring(linea.IndexOf('\t')+1);
			cant = Math.Min(cant, linea.Length);
			return linea.Substring(0, cant);
		}
		
		public static LectorDeArchivos getInstance(Manejador m){
			if (unicaInstancia == null){
				unicaInstancia = new LectorDeArchivos(m);
			}
			
			return unicaInstancia;
		}
	}
}
