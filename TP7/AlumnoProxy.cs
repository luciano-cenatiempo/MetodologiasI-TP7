/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 7/11/2024
 * Hora: 14:04
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of AlumnoProxy.
	/// </summary>
	public class AlumnoProxy : IAlumno, Comparable
	{
		private IAlumno alumnoReal = null;
		private string nombre;
		private int opcionCrear;
		public AlumnoProxy(string n, int opt)
		{
			this.nombre = n;
			this.opcionCrear = opt;
		}

		#region IAlumno implementation

		public string getNombre()
		{
			return nombre;
		}
		
		public int getDni(){
			if(alumnoReal == null){
				alumnoReal = (IAlumno) FabricaDeComparables.crearPorArchivo(opcionCrear);
				alumnoReal.setNombre(nombre);}
			return alumnoReal.getDni();
		}

		public int getLegajo()
		{
			if(alumnoReal == null){
				alumnoReal = (IAlumno) FabricaDeComparables.crearPorArchivo(opcionCrear);
				alumnoReal.setNombre(nombre);}
			return alumnoReal.getLegajo();
		}
		
		public void setNombre(string nombre){
			this.nombre = nombre;
		}

		public int getPromedio()
		{
			if(alumnoReal == null){
				alumnoReal = (IAlumno) FabricaDeComparables.crearPorArchivo(opcionCrear);
				alumnoReal.setNombre(nombre);}
			return alumnoReal.getPromedio();
		}

		public void setCalificacion(int calificacion)
		{
			if(alumnoReal == null){
				alumnoReal = (IAlumno) FabricaDeComparables.crearPorArchivo(opcionCrear);
				alumnoReal.setNombre(nombre);}
			alumnoReal.setCalificacion(calificacion);
		}

		public int getCalificacion()
		{
			if(alumnoReal == null){
				alumnoReal = (IAlumno) FabricaDeComparables.crearPorArchivo(opcionCrear);
				alumnoReal.setNombre(nombre);}
			return alumnoReal.getCalificacion();
		}

		public int responderPregunta(int pregunta)
		{
			if(alumnoReal == null){
				alumnoReal = (IAlumno) FabricaDeComparables.crearPorArchivo(opcionCrear);
				alumnoReal.setNombre(nombre);}
			return alumnoReal.responderPregunta(pregunta);
		}

		public string mostrarCalificacion()
		{
			if(alumnoReal == null){
				alumnoReal = (IAlumno) FabricaDeComparables.crearPorArchivo(opcionCrear);
				alumnoReal.setNombre(nombre);}
			return alumnoReal.mostrarCalificacion();
		}

		#endregion

		#region Comparable implementation

		public bool sosIgual(Comparable com)
		{
			if(alumnoReal == null){
				alumnoReal = (IAlumno) FabricaDeComparables.crearPorArchivo(opcionCrear);
				alumnoReal.setNombre(nombre);}
			if (com is AlumnoProxy) {
				return alumnoReal.sosIgual(((AlumnoProxy)(com)).alumnoReal);
			}
			return alumnoReal.sosIgual(com);
		}

		public bool sosMenor(Comparable com)
		{
			if(alumnoReal == null){
				alumnoReal = (IAlumno) FabricaDeComparables.crearPorArchivo(opcionCrear);
				alumnoReal.setNombre(nombre);}
			if (com is AlumnoProxy) {
				return alumnoReal.sosMenor(((AlumnoProxy)(com)).alumnoReal);
			}
			return alumnoReal.sosMenor(com);
		}

		public bool sosMayor(Comparable com)
		{
			if(alumnoReal == null){
				alumnoReal = (IAlumno) FabricaDeComparables.crearPorArchivo(opcionCrear);
				alumnoReal.setNombre(nombre);}
			if (com is AlumnoProxy) {
				return alumnoReal.sosMayor(((AlumnoProxy)(com)).alumnoReal);
			}
			return alumnoReal.sosMayor(com);
		}

		#endregion
	}
}
