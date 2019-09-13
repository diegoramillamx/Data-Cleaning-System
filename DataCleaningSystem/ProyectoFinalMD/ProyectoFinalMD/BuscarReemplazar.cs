using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ProyectoFinalMD
{
	public partial class BuscarReemplazar : Form
	{
		private int index;
		private string valorViejo, valorNuevo;
		
		public BuscarReemplazar(List<string> atributos)
		{
			InitializeComponent();
			
			foreach (string item in atributos)
			{
				cboNombreAtributos.Items.Add(item);
			}
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			index = cboNombreAtributos.SelectedIndex;
			
			if (index == -1)
			{
				MessageBox.Show("Seleccione un atributo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			valorViejo = txtViejoValor.Text;
			valorNuevo = txtValorNuevo.Text;
			this.Close();
		}
		
		public string obtenerValorViejo()
		{
			return valorViejo;
		}
		
		public string obtenerValorNuevo()
		{
			return valorNuevo;
		}
		
		public int obtenerIndex()
		{
			return index;
		}
	}
}
