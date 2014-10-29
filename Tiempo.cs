using System;

namespace crono
{
	public class Tiempo //: Atleta, Prueba
	{
		public Tiempo (int horas, int minutos, int segundos, int centesimas, double milesimas) //: atributosHeredados
		{
			this.Horas = horas;
			this.Minutos = minutos;
			this.Segundos = segundos;
			this.Centesimas = centesimas;
			this.Milesimas = milesimas;
		}
		public Tiempo () //: heredados
		{}

		public int Horas{
			get;
			set;
		}
		public int Minutos{
			get;
			set;
		}
		public int Segundos{
			get;
			set;
		}
		public int Centesimas {
			get;
			set;
		}
		public double Milesimas {
			get;
			set;
		}

		public void setTiempo (int horas, int minutos, int segundos, int centesimas, double milesimas)
		{
			this.Horas = horas;
			this.Minutos = minutos;
			this.Segundos = segundos;
			this.Centesimas = centesimas;
			this.Milesimas = milesimas;
		}

		public void introducirTiempo(){

			Console.WriteLine ("Introduzca horas: ");
			this.Horas = int.Parse (Console.ReadLine ());
			Console.WriteLine ("Introduzca minutos");
			this.Minutos = int.Parse (Console.ReadLine ());
			Console.WriteLine ("Introduzca segundos: ");
			this.Segundos = int.Parse (Console.ReadLine ());
			Console.WriteLine ("Introduzca centesimas: ");
			this.Centesimas = int.Parse (Console.ReadLine ());
			Console.WriteLine ("Introduzca milésimas: ");
			this.Milesimas = double.Parse (Console.ReadLine ());
		}

		/*ESTO NO HARIA FALTA PORQUE ESTAN LOS GETTERS Y SETTERS REDUCIDOS
		public void setTiempo (int horas, int minutos, int segundos, int centesimas, double milesimas)
		{
			this.horas = horas;
			this.minutos = minutos;
			this.segundos = segundos;
			this.centesimas = centesimas;
			this.milesimas = milesimas;
		}

*/	
		public override string ToString ()
		{
			return string.Format ("\nTiempo: \n\tHoras = {0}, \n\tMinutos = {1}, \n\tSegundos = {2}, \n\tCentesimas = {3}, \n\tMilesimas = {4}" +
									"\n\n TOTAL {0}h : {1}' : {2}'' : {3}cs: {4}ms"
			                      , Horas, Minutos, Segundos, Centesimas, Milesimas );
		}
	
/*ESTO YA LO CREAN LOS GETTERS Y SETTERS
		private int horas;
		private int minutos;
		private int segundos;
		private int centesimas;
		private double milesimas;
	}
*/
	}
}

