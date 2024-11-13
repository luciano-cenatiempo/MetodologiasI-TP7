/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 29/10/2024
 * Hora: 12:57
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace TP6
{
	/// <summary>
	/// Description of Profesor.
	/// </summary>
	public class Profesor : Persona, Observado
	{
		int antiguedad;
		
		// a profesor se le agrega una lista de observadores
		List<Observador> observadores;
		private bool hablando;
		
		public Profesor()
		{
			this.observadores = new List<Observador>();
			this.hablando = false;
		}
		
		public Profesor(string nombre, int dni, int antiguedad)
		{
			this.nombre = nombre;
			this.dni = dni;
			this.antiguedad = antiguedad;
			
			observadores = new List<Observador>();
			this.hablando = false;
			

		}
		
		public void setAntiguedad(int ant){
			this.antiguedad = ant;
		}
		
		public int getAntiguedad(){
			return this.antiguedad;
			
		}
		
		public bool getHablando(){
			return this.hablando;
		}
		
		
		public void hablarAlaClase(){
			Console.WriteLine("Hablando de algun tema");
			this.hablando = true;
			notificar(); // se notifica a los observadores del cambio de estado
		}
		
		public void escribirEnElPizarron(){
			Console.WriteLine("Escribiendo en el pizarron");
			this.hablando = false;
			notificar();// se notifica a los observadores del cambio de estado
		}
		
		public override bool sosIgual(Comparable com){
			return this.antiguedad == ((Profesor)com).getAntiguedad();
		}
		public override bool sosMenor(Comparable com){
			return this.antiguedad < ((Profesor)com).getAntiguedad();
		}
		public override bool sosMayor(Comparable com){
			return this.antiguedad > ((Profesor)com).getAntiguedad();
		}
		
		
		
		#region Observado implementation
		public void agregarObservador(Observador o)
		{
			observadores.Add(o);
		}
		public void quitarObservador(Observador o)
		{
			observadores.Remove(o);
		}
		public void notificar()
		{
			foreach(Observador obs in observadores){
				obs.actualizar(this);
			}
		}
		#endregion
	}
}
