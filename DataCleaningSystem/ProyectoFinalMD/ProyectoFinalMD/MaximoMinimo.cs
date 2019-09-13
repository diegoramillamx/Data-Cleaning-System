using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinalMD
{
	public partial class MaximoMinimo : Form
	{
		private int maximo, minimo, nuevoMaximo, nuevoMinimo;
		
		public MaximoMinimo()
		{
			InitializeComponent();
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			maximo = (int)nupMaximo.Value;
			minimo = (int)nupMinimo.Value;
			nuevoMaximo = (int)nupNuevoMaximo.Value;
			nuevoMinimo = (int)nupNuevoMinimo.Value;
			
			if (maximo <= minimo || nuevoMaximo <= nuevoMinimo)
			{
				MessageBox.Show("Valores incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			
			this.Close();
		}
		
		public int obtenerMaximo()
		{
			return maximo;
		}
			
		public int obtenerMinimo()
		{
			return minimo;
		}
		
		public int obtenerMaximoNuevo()
		{
			return nuevoMaximo;
		}
		
		public int obtenerMinimoNuevo()
		{
			return nuevoMinimo;
		}
	}
}
