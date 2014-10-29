using System;
using System.Windows.Forms;
using System.Drawing;

namespace crono.iu
{
	public class MainWindow : Form
	{
		public MainWindow ()
		{
			this.build();
		}
	
		private void build()
		{
			this.Text = "Tiempo";

			//panel
			var pnlPpal = new TableLayoutPanel();
			pnlPpal.Dock = DockStyle.Fill;

			//Panel Horas
			var pnlHoras = new Panel();
			var lblHoras = new Label();
			this.edHoras = new TextBox();

			pnlHoras.Dock = DockStyle.Fill;
			lblHoras.Text = "Horas:";
			this.edHoras.Text = "0";
			this.edHoras.TextAlign = HorizontalAlignment.Right;
			//this.edHoras.TextAlignChanged += (object sender, EventArgs e) => this.;

			lblHoras.Dock = DockStyle.Left;
			this.edHoras.Dock = DockStyle.Fill;
			pnlHoras.Controls.Add(this.edHoras);
			pnlHoras.Controls.Add (lblHoras);

			//Panel Minutos
			var pnlMinutos = new Panel();
			var lblMinutos = new Label();
			this.edMinutos = new TextBox();

			pnlMinutos.Dock = DockStyle.Fill;
			lblMinutos.Text = "Minutos:";
			this.edMinutos.Text = "0";
			this.edMinutos.TextAlign = HorizontalAlignment.Right;
			//this.edMinutos.TextAlignChanged += (object sender, EventArgs e) => this.;

			lblHoras.Dock = DockStyle.Left;
			this.edMinutos.Dock = DockStyle.Fill;
			pnlMinutos.Controls.Add(this.edMinutos);
			pnlMinutos.Controls.Add (lblMinutos);

			//Panel Segundos
			var pnlSegundos = new Panel();
			var lblSegundos = new Label();
			this.edSegundos = new TextBox();

			pnlSegundos.Dock = DockStyle.Fill;
			lblSegundos.Text = "Segundos:";
			this.edSegundos.Text = "0";
			this.edSegundos.TextAlign = HorizontalAlignment.Right;
			//this.edSegundos.TextAlignChanged += (object sender, EventArgs e) => this.;

			lblSegundos.Dock = DockStyle.Left;
			this.edSegundos.Dock = DockStyle.Fill;
			pnlSegundos.Controls.Add(this.edSegundos);
			pnlSegundos.Controls.Add (lblSegundos);

			//Panel Centésimas
			var pnlCentesimas = new Panel();
			var lblCentesimas = new Label();
			this.edCentesimas = new TextBox();

			pnlCentesimas.Dock = DockStyle.Fill;
			lblCentesimas.Text = "Centesimas:";
			this.edCentesimas.Text = "0";
			this.edCentesimas.TextAlign = HorizontalAlignment.Right;
			//this.edHoras.TextAlignChanged += (object sender, EventArgs e) => this.;

			lblCentesimas.Dock = DockStyle.Left;
			this.edCentesimas.Dock = DockStyle.Fill;
			pnlCentesimas.Controls.Add(this.edCentesimas);
			pnlCentesimas.Controls.Add (lblCentesimas);

			//Panel Milesimas
			var pnlMilesimas = new Panel();
			var lblMilesimas = new Label();
			this.edMilesimas = new TextBox();

			pnlMilesimas.Dock = DockStyle.Fill;
			lblMilesimas.Text = "Milésimas:";
			this.edMilesimas.Text = "0";
			this.edMilesimas.TextAlign = HorizontalAlignment.Right;
			//this.edMilesimas.TextAlignChanged += (object sender, EventArgs e) => this.;

			lblMilesimas.Dock = DockStyle.Left;
			this.edMilesimas.Dock = DockStyle.Fill;
			pnlMilesimas.Controls.Add(this.edMilesimas);
			pnlMilesimas.Controls.Add (lblMilesimas);

			//panel del boton
			var pnlBoton = new Panel();
			pnlBoton.Dock=DockStyle.Fill;
			var btadd = new Button();
			btadd.Text="Añadir tiempo";
			btadd.Dock=DockStyle.Top;
			btadd.Click += (sender, e) => this.addTiempo(edHoras, edMinutos, edSegundos, edCentesimas, edMilesimas);
			pnlBoton.Controls.Add(btadd);

			//Panel resultante
			var pnlRes=new Panel();
			//this.edRes=new Label();
			pnlRes.Dock=DockStyle.Fill;
			//this.edRes.Text="";
			//this.edRes.AutoSize=true;
			this.Dock=DockStyle.Fill;
			//pnlRes.Controls.Add(this.edRes);

			//Juntarlo todo
			pnlPpal.Controls.Add (pnlHoras);
			pnlPpal.Controls.Add (pnlMinutos);
			pnlPpal.Controls.Add (pnlSegundos);
			pnlPpal.Controls.Add (pnlCentesimas);
			pnlPpal.Controls.Add (pnlMilesimas);
			pnlPpal.Controls.Add (pnlBoton);
			pnlPpal.Controls.Add (pnlRes);
			this.Controls.Add (pnlPpal);
			this.MinimumSize=new System.Drawing.Size(220, 600);
			this.MaximumSize=new System.Drawing.Size(400, 600);
		}
		/*private void botonAddTime_Click (object sender, EventArgs e)
		{
			MessageBox.Show("Añada");
		}
		
		public Button boton1;
*/

		private void addTiempo(TextBox horas, TextBox minutos, TextBox segundos, TextBox centesimas, TextBox milesimas){
		
			Tiempo t = new Tiempo (Convert.ToInt32 (horas.Text),
				Convert.ToInt32 (minutos.Text),
				Convert.ToInt32 (segundos.Text),
				Convert.ToInt32 (centesimas.Text),
				Convert.ToDouble (milesimas.Text));
				
		}

		private TextBox edHoras;
		private TextBox edMinutos;
		private TextBox edSegundos;
		private TextBox edCentesimas;
		private TextBox edMilesimas;
		//private Label edRes;

	}
}

