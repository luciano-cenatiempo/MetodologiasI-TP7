/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 12/11/2024
 * Hora: 09:40
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of Chinchon.
	/// </summary>
	public class Chinchon : JuegoDeCartas
	{
		
		private int puntosJugador1 = 0;
		private int puntosJugador2 = 0;
		private Persona ganador;
		private Persona jugador1;
		private Persona jugador2;
		private int cantManos = 0;
		private Random rnd = new Random();
		private int manosTotales;
		private Persona ganadorPartida;
		
		
		public Chinchon(Persona jug1, Persona jug2)
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
			this.setGanador(null);
			Console.WriteLine("Repartiendo 7 cartas a cada jugador");
			cantManos = 0;
			manosTotales = rnd.Next(3,6);
		}
		public override bool hayGanador()
		{
			cantManos++;
			if(cantManos == manosTotales){
				
				if(rnd.Next(1,3) == 1){
					this.setGanador(jugador1);
					puntosJugador1++;
				}else{
					this.setGanador(jugador2);
					puntosJugador2++;
				}
			}
			if(ganador != null){
				return true;
			}else{
				return false;
			}
			
		}
		public override void tomarCarta()
		{
			Console.WriteLine("Levantando carta del mazo");
		}
		
		public override void descartar()
		{
			Console.WriteLine("Descartando carta al mazo");
		}
		
		public override void informarGanador()
		{
			Console.WriteLine("El ganador de esta mano es: " + ganador.getNombre());
		}
		
		public override Persona ganadorDePartida()
		{
			if(puntosJugador1 >= 10){
				ganadorPartida = jugador1;
			}
			
			if(puntosJugador2 >= 10){
				ganadorPartida = jugador2;
			}
			
			return ganadorPartida;
			
			
			
		}
		#endregion
	}
}
