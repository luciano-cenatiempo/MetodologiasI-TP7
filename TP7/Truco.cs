/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 12/11/2024
 * Hora: 15:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of Truco.
	/// </summary>
	public class Truco : JuegoDeCartas
	{
		private int puntosJugador1 = 0;
		private int puntosJugador2 = 0;
		private Persona ganador;
		private Persona jugador1;
		private Persona jugador2;
		private Random rnd = new Random();
		private int cantManos;
		
		
		public Truco(Persona jug1, Persona jug2)
		{
			this.jugador1 = jug1;
			this.jugador2 = jug2;
		}
		
		public void setGanador(Persona ganador){
			this.ganador = ganador;
		}
		
		public Persona getGanador(){
			return this.ganador;
		}
		
		
		#region implemented abstract members of JuegoDeCartas
		public override void repartirCartas()
		{	
			cantManos = 0;
			Console.WriteLine("Repartiendo 3 cartas a cada jugador");
		}
		public override bool hayGanador()
		{
			
			if(cantManos != 6){
				cantManos++;
				if(cantManos == 2){
					// Envido
					int envido = rnd.Next(0,3);
					if(envido == 1){
						puntosJugador1+=2;
						Console.WriteLine(jugador1.getNombre() +": ganó el envido");
					}
					if(envido == 2){
						puntosJugador2+=2;
						Console.WriteLine(jugador2.getNombre() +": ganó el envido");
						
					}
					
					if(envido == 0){
						Console.WriteLine("Nadie cantó el envido");
					}
					
				}
				
				if(puntosJugador1 >= 15){
					setGanador(jugador1);
				}
				
				if(puntosJugador2 >= 15){
					setGanador(jugador2);
				}
					
				return false;
			}
				int truco = rnd.Next(1,3);
				int puntosTruco = rnd.Next(2,5);
				
				if(ganador == null){ // si no ganó con el truco 
					
					if(truco == 1){
						puntosJugador1+=puntosTruco;
						Console.WriteLine(jugador1.getNombre() +": ganó " + puntosTruco + " puntos del Truco");
					}
					if(truco == 2){
						puntosJugador2+=puntosTruco;
						Console.WriteLine(jugador2.getNombre() +": ganó " + puntosTruco + " puntos del Truco");
						
					}
				}

				return true;
			
		}
			
		public override void tomarCarta()
		{
			// nadie toma cartas
		}
		
		public override void descartar()
		{
			Console.WriteLine("Descartando carta al mazo");
		}
		
		public override void informarGanador()
		{		

			
			Console.WriteLine("---Marcador---");
				Console.WriteLine(jugador1.getNombre() + ": " + puntosJugador1);
				Console.WriteLine(jugador2.getNombre() + ": " + puntosJugador2);
			
				

		}
		
		public override Persona ganadorDePartida()
		{
			if(puntosJugador1 >= 15){
				setGanador(jugador1);
			}
				
			if(puntosJugador2 >= 15){
				setGanador(jugador2);
			}
			return ganador;
		}
		#endregion
	}
	
}
