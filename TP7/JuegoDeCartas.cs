/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 12/11/2024
 * Hora: 09:36
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP6
{
	/// <summary>
	/// Description of JuegoDeCartas.
	/// </summary>
	public abstract class JuegoDeCartas
	{
		public JuegoDeCartas()
		{
		}
		
		public void jugar(){
			
//			mezclarMazo();
//				repartirCartas();
//				while(!hayGanador()){
//					tomarCarta();
//					descartar();
//				}
//				informarGanador();
			
			
			while(ganadorDePartida() == null){
				mezclarMazo();
				repartirCartas();
				while(!hayGanador()){
					tomarCarta();
					descartar();
				}
				informarGanador();
			}
			Console.WriteLine("**** EL GANADOR ES " + ganadorDePartida().getNombre()+ " ****");
			
		}
		
		public void mezclarMazo(){
			Console.WriteLine("Mezclando las cartas");
			
		}
		
		public abstract void repartirCartas();
		public abstract bool hayGanador();
		public abstract void tomarCarta();
		public abstract void descartar();
		public abstract void informarGanador();
		public abstract Persona ganadorDePartida();
	}
}
