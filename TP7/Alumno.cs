/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 20/9/2024
 * Hora: 12:45
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno : Persona, IAlumno, Observador
	{
		static Random rnd = new Random();
		private int legajo;
		private int promedio;
		private int calificacion;
		private IEstrategiaComparacion estrategia;
		
		public Alumno(){
			this.estrategia = new PorPromedio();
		}
		
		public Alumno(string n, int d, int l, int p )
		{
			this.nombre = n;
			this.dni = d;
			this.legajo = l;
			this.promedio = p;
			this.estrategia = new PorPromedio();
			this.calificacion = 0;
		}
		
		public virtual int responderPregunta(int pregunta){
			return rnd.Next(1,4);
		}
		
		public string mostrarCalificacion(){
			return nombre + " " + this.getCalificacion();
		}
		
		public void setEstrategia(IEstrategiaComparacion estra){
			this.estrategia = estra;
		}
		
		public void setCalificacion(int c){
			this.calificacion = c;
		}
		
		public int getCalificacion(){
			return this.calificacion;
		}
		
		public int getLegajo(){
			return this.legajo;
		}
		
		public int getPromedio(){
			return this.promedio;
		}
		
		public void setNombre(string nombre){
			this.nombre = nombre;
		}
		
		public void setDni(int dni){
			this.dni = dni;
		}
		
		public void setLegajo(int legajo){
			this.legajo = legajo;
		}
		
		public void setPromedio(int promedio){
			this.promedio = promedio;
		}
		
		public override bool sosIgual(Comparable com){
			return this.estrategia.sosIgual(this,(IAlumno)com);
			// return this.promedio == ((Alumno)com).getPromedio();
		}
		public override bool sosMenor(Comparable com){
			return this.estrategia.sosMenor(this,(IAlumno)com);
			//return this.promedio < ((Alumno)com).getPromedio();
		}
		public override bool sosMayor(Comparable com){
			return this.estrategia.sosMayor(this,(IAlumno)com);
			//return this.promedio > ((Alumno)com).getPromedio();
		}
		
		public void prestarAtencion(){
			Console.WriteLine("Prestando atencion");
		}
		
		public void distraerse(){
			int opcion = Alumno.rnd.Next(1,4);
			switch(opcion){
					case 1: Console.WriteLine("Mirando el celular");break;
					case 2: Console.WriteLine("Dibujando en el margen de la carpeta");break;
					case 3: Console.WriteLine("Tirando aviones de papel");break;
			}
		}
		
		
		public override string ToString(){
			return this.getNombre() + "- Dni: " + this.getDni().ToString()+ "- Promedio: "  + this.getPromedio().ToString()+ "- Legajo: "  + this.getLegajo().ToString() ;
		}

		#region Observador implementation

		public void actualizar(Observado o)
		{
			if(((Profesor)(o)).getHablando()){
				distraerse();
			}else{
				prestarAtencion();
			}
		}

		#endregion
	}
}
