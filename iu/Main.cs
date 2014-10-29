using System;
using System.Windows.Forms;
using System.Drawing;

using System.Collections.Generic; // para las listas

namespace crono.iu
{
	class MainClass : MainWindow
	{
		[STAThread]
		public static void Main ()
		{
			//Directivas de interfaz
			Application.EnableVisualStyles ();
			Application.Run (new MainWindow());

			//Declaración de Variables, CASO DE PRUEBA
			Tiempo t1 = new Tiempo();
			//List<Tiempo> listaTiempos = new List<Tiempo>(); //igual la lista no nos hace falta por el XML

			t1.introducirTiempo();
			//listaTiempos.Add();

			

			//t1.setTiempo (horas, minutos, segundos, centesimas, milesimas); si tuvieramos las variables declaradas

			Console.WriteLine (t1.ToString ());
		}
	}
}
