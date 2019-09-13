using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinalMD
{
	public partial class MuestreoDatos : Form
	{
		private int instancias;
		
		public MuestreoDatos(int instanciasMaximas)
		{
			InitializeComponent();
			nupInstancias.Maximum = instanciasMaximas;
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			instancias = (int)nupInstancias.Value;
			this.Close();
		}
		
		public int obtenerInstancias() 
		{
			return instancias;
		}
	}
}
