/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 3/9/2024
 * Hora: 14:50
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Threading;

namespace TP6
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			simularClaseConAluCompuesto();
			Console.ReadKey();
			
		}
		
		// EJERCICIO 6 TP6
		public static void jugarTruco(string nombre1, string nombre2){
			Persona jugador1 = new Persona();
			jugador1.setNombre(nombre1);
			
			Persona jugador2  = new Persona();
			jugador2.setNombre(nombre2);
			
			JuegoDeCartas truco = new Truco(jugador1, jugador2);
			
			truco.jugar();

		}
		
		public static void jugarChinchon(string nombre1, string nombre2){
			Persona jugador1 = new Persona();
			jugador1.setNombre(nombre1);
			
			Persona jugador2  = new Persona();
			jugador2.setNombre(nombre2);
			
			JuegoDeCartas chinchon = new Chinchon(jugador1, jugador2);
			
			chinchon.jugar();

		}
		
		// EJERCICIO 3-4-5 TP6
		public static void simularJuegosCarta(){
			Persona jugador1 = new Persona();
			jugador1.setNombre("Juan");
			
			Persona jugador2  = new Persona();
			jugador2.setNombre("Carla");
			
			JuegoDeCartas chinchon = new Chinchon(jugador1, jugador2);
			chinchon.jugar();
		}
		
		
		// Ejercicio 2 TP6 - MODIFICADO POR TP 7
		public static void simularClaseConAluCompuesto(){
			Teacher teacher = new Teacher();
			for (int i = 0; i < 6; i++)
			{
				// Ejercicio 1 TP 5
				// Creo un proxy para un alumno
				
				
				IAlumno alu;
				if(i == 1){
					// instancio el alumno compuesto
					alu = (AlumnoCompuesto) FabricaDeComparables.crearPorArchivo(FabricaDeComparables.ALUMNO_COMPUESTO);
				
					
				}else{
					
					alu = (Alumno) FabricaDeComparables.crearAleatorio(FabricaDeComparables.ALUMNO);
					alu = new AlumnoDecoratorLegajo(alu);
					alu = new AlumnoDecoratorLetras(alu);
					alu = new AlumnoDecoratorTipoNota(alu);
					alu = new AlumnoDecoratorRecuadro(alu);
				}

				
				
				Student student = new AdaptadorAlumno(alu);
				teacher.goToClass(student);
			}
			
			
			
			for (int i = 0; i < 2; i++)
            {
				IAlumno alu2;
				alu2 = (AlumnoMuyEstudioso)(FabricaDeComparables.crearPorTeclado(FabricaDeComparables.ALUMNO_ESTUDIOSO));
				
				alu2 = new AlumnoDecoratorLegajo(alu2);
				alu2 = new AlumnoDecoratorLetras(alu2);
				alu2= new AlumnoDecoratorTipoNota(alu2);
				alu2 = new AlumnoDecoratorRecuadro(alu2);
				Student student = new AdaptadorAlumno(alu2);
                teacher.goToClass(student);
            }

            teacher.teachingAClass();
		}
		
		
		// EJERCICIO 10 TP 5
		public static void instanciarAula(){
			Aula aula = new Aula();
			Pila pila = new Pila();
			
			
			pila.setOrdenInicio(new OrdenInicio(aula));
			pila.setOrdenAulaLlena(new OrdenAulaLlena(aula));
			pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
			
			llenar(pila,FabricaDeComparables.ALUMNO);
			llenar(pila,FabricaDeComparables.ALUMNO_ESTUDIOSO);
			
			// COLA
			
			Cola cola = new Cola();
			
			
			cola.setOrdenInicio(new OrdenInicio(aula));
			cola.setOrdenAulaLlena(new OrdenAulaLlena(aula));
			cola.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
			
			llenar(cola,FabricaDeComparables.ALUMNO);
			llenar(cola,FabricaDeComparables.ALUMNO_ESTUDIOSO);
			
			// Conjunto
			Conjunto conjunto = new Conjunto();
			
			
			conjunto.setOrdenInicio(new OrdenInicio(aula));
			conjunto.setOrdenAulaLlena(new OrdenAulaLlena(aula));
			conjunto.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
			
			llenar(conjunto,FabricaDeComparables.ALUMNO);
			llenar(conjunto,FabricaDeComparables.ALUMNO_ESTUDIOSO);
		
		}
		
		
		// EJERCICIO 4 TP 4
		public static IAlumno decorarAlumno(IAlumno alumno){
			alumno = new AlumnoDecoratorLegajo(alumno);
			alumno = new AlumnoDecoratorLetras(alumno);
			alumno = new AlumnoDecoratorTipoNota(alumno);
			alumno = new AlumnoDecoratorRecuadro(alumno);
			return alumno;
		}
		public static void simularClase(){
			Teacher teacher = new Teacher();
			
			for (int i = 0; i < 10; i++)
            {
				// Ejercicio 1 TP 5
				// Creo un proxy para un alumno 
			
				
				IAlumno alu;
				if(i == 1){
					alu = new AlumnoProxy("Juan",FabricaDeComparables.ALUMNO);
				}else{
					
					alu = (Alumno) FabricaDeComparables.crearAleatorio(FabricaDeComparables.ALUMNO);
				}
				alu = new AlumnoDecoratorLegajo(alu);
				alu = new AlumnoDecoratorLetras(alu);
				alu = new AlumnoDecoratorTipoNota(alu);
				alu = new AlumnoDecoratorRecuadro(alu);
				
				
				Student student = new AdaptadorAlumno(alu);
                teacher.goToClass(student);
            }
			
			for (int i = 0; i < 10; i++)
            {
				IAlumno alu2;
				alu2 = (AlumnoMuyEstudioso)(FabricaDeComparables.crearAleatorio(FabricaDeComparables.ALUMNO_ESTUDIOSO));
				
				alu2 = new AlumnoDecoratorLegajo(alu2);
				alu2 = new AlumnoDecoratorLetras(alu2);
				alu2= new AlumnoDecoratorTipoNota(alu2);
				alu2 = new AlumnoDecoratorRecuadro(alu2);
				Student student = new AdaptadorAlumno(alu2);
                teacher.goToClass(student);
            }

            teacher.teachingAClass();
		}
		
		
		
		
		public static void ejerciciosOtrosTp(){
			const int ALUMNO = 1;
			const int NUMERO = 2;
			const int PROFESOR = 3;
			// TODO: Implement Functionality Here
			
/*			
			Pila p = new Pila();
			Cola c = new Cola();
			
			ColeccionMultiple multiple = new ColeccionMultiple(p,c);
			llenar(p);
			
			
			
			llenar(c);
			informar(p);
			informar(c);
			informar(multiple);
			
*/			
/*
 // Llenar personas
			Pila p = new Pila();
			Cola c = new Cola();
			
			ColeccionMultiple multiple = new ColeccionMultiple(p,c);
			llenarPersonas(p);
			
			
			
			llenarPersonas(c);
			informar(multiple);
			
*/			
// llenar Alumnos
//			Pila p = new Pila();
//			Cola c = new Cola();
//			
//			ColeccionMultiple multiple = new ColeccionMultiple(p,c);
//			llenarAlumnos(p);
//			
//			
//			
//			llenarAlumnos(c);
//			informar(multiple);

			// Ejercicio 14 - TP3
			
			Profesor profe = new Profesor("Hernan Gómez",33445544,6);
			
			for (int i = 0; i < 20; i++) {
				Alumno alu = (Alumno)(FabricaDeComparables.crearAleatorio(ALUMNO));
				
				profe.agregarObservador(alu);
				
			}
			
			dictadoDeClases(profe);
			
			// Llenar con funcion imprimirElementos (ejercicio 8)
		
			Pila pila = new Pila();
			Cola cola = new Cola();
			Conjunto conjunto = new Conjunto();
			Diccionario diccionario = new Diccionario();
			
			llenar(pila, ALUMNO);
			llenar(cola, ALUMNO);
			llenar(conjunto, ALUMNO);
			//llenarAlumnos(diccionario);
			
			Console.WriteLine("-------------- ELEMENTOS PILA -----------------");
			imprimirElementos(pila);
			Console.WriteLine("-------------- ELEMENTOS COLA -----------------");			
			imprimirElementos(cola);
			Console.WriteLine("-------------- ELEMENTOS CONJUNTO -----------------");			
			imprimirElementos(conjunto);
			//imprimirElementos(diccionario);
			
			
			// EJERCICIO 10 - 
			Console.WriteLine("----------Ejercicio 10 ------------------");
			
			Pila pila2= new Pila();
			llenar(pila2,ALUMNO);
			
			Console.WriteLine("POR NOMBRE");
			cambiarEstrategia(pila2, new PorNombre());
			informar(pila2,ALUMNO);
			
			Console.WriteLine("POR LEGAJO");
			cambiarEstrategia(pila2, new PorLegajo());
			informar(pila2, ALUMNO);
			
			Console.WriteLine("POR PROMEDIO");
			cambiarEstrategia(pila2, new PorPromedio());
			informar(pila2);
			
			Console.WriteLine("POR DNI");
			cambiarEstrategia(pila2, new PorDni());
			informar(pila2, ALUMNO);
			
			// EJERCICIO 9 PRACTICA 3 - PROFESOR
			Pila pila3 = new Pila();
			
			llenar(pila3, PROFESOR);
			informar(pila3,PROFESOR);
			
		}
		
		
		
		public static void llenar(Coleccionable col){
			Random rnd = new Random();
			
			for (int i = 0; i < 20; i++) {
				Comparable com = new Numero(rnd.Next(0,19));
				col.agregar(com);
			}
		}
		
		public static void informar(Coleccionable col){
			Console.WriteLine("Cuantos: " + col.cuantos());
			Console.WriteLine("Minimo: " + col.minimo());
			Console.WriteLine("Maximo: " + col.maximo());
			
			// Comparar, usado solo para el numero
			/*
			Console.WriteLine("Ingrese número para comparar: ");
			string teclado =  Console.ReadLine();
			int valor = Int32.Parse(teclado);
			Numero num = new Numero(valor);
			
			if (col.contiene(num)) {
			    	Console.WriteLine("El elemento leído esta en la coleccion");
			    }else{
			    	Console.WriteLine("El elemento leído NO esta en la coleccion");
			    }
			*/
			
			
			
			
			
		}
		
		
		
		// LLENAR PRACTICA 3 EJERCICIO 6
		public static void llenar(Coleccionable col, int opcion ){
			for (int i = 0; i < 20; i++) {
				Comparable com = FabricaDeComparables.crearAleatorio(opcion);
				col.agregar(com);
			}
		}
		
		
		// INFORMAR PRACTICA 3 EJERCICIO 6
		public static void informar(Coleccionable col, int opcion){
			Console.WriteLine("Cuantos: " + col.cuantos());
			Console.WriteLine("Minimo: " + col.minimo());
			Console.WriteLine("Maximo: " + col.maximo());
			
			Comparable com = FabricaDeComparables.crearPorTeclado(opcion);
			
			if(col.contiene(com)){
				Console.WriteLine("El elemento leido está en la colección");
			}else{
				Console.WriteLine("El elemento leido NO está en la colección");
				
			}
		}
		
		public static void llenarPersonas(Coleccionable col ){
			string[] nombre = {"Facundo", "Pedro", "Juan", "Victoria", "María", "Nicolás", "Pablo", "Jazmín"};
			int[] dni = {1111,2222,3333,4444,5555,6666,7777,8888,9999};
			
			Random rnd = new Random();
			Comparable com;
			for (int i = 0; i < 20; i++) {
				com = new Persona(nombre[rnd.Next(0,8)], dni[new Random().Next(0,9)]);
					col.agregar(com);
			}
			
		}
		
		public static void llenarAlumnos(Coleccionable col){
			string[] nombres = {"Facundo", "Pedro", "Juan", "Victoria", "María", "Nicolás", "Pablo", "Jazmín"};
			
			Random rnd = new Random();
			Alumno alu;
			for (int i = 0; i < 20; i++) {
				alu = new Alumno(nombres[rnd.Next(0,8)], rnd.Next(39000000,45000000), rnd.Next(1000,3000), rnd.Next(0,11));
				alu.setEstrategia(new PorPromedio());
					col.agregar(alu);
			}
			
		}
		
		// funcion que imprime elementos del coleccionable ( EJERCICIO 7) 
		
		public static void imprimirElementos (Iterable col){
			Iterador ite = col.crearIterador();
			ite.primero();
			while (!ite.fin()) {
				Console.WriteLine(ite.actual());
				ite.siguiente();
			}
		}
		
		
		// FUNCION QUE CAMBIA ESTRATEGIA ( EJERCICIO 9 )
		public static void cambiarEstrategia(Iterable col , IEstrategiaComparacion estrategia){
			
			Iterador ite = col.crearIterador();
			ite.primero();
			
	
			while (!ite.fin()) {
				((Alumno)ite.actual()).setEstrategia(estrategia);
				
				ite.siguiente();
				
			}
			
				
		}
		
		public static void dictadoDeClases(Profesor profe){
			for (int i = 0; i < 5; i++) {
				profe.hablarAlaClase();
				profe.escribirEnElPizarron();
				
			}
		}
		
	
	}
}