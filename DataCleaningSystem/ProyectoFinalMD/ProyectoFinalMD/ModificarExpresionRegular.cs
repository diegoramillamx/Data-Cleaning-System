using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ProyectoFinalMD
{
	public partial class ModificarExpresionRegular : Form
	{
		private List<string> expresiones;
		
		public ModificarExpresionRegular(List<string> atributos, List<string> _expresiones)
		{
			InitializeComponent();
			
			foreach (string item in atributos)
			{
				cboNombreAtributos.Items.Add(item);
			}
			
			expresiones = _expresiones;
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			int index = cboNombreAtributos.SelectedIndex;
			
			if (index == -1) 
			{
				MessageBox.Show("Debe de seleccionar un atributo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			expresiones[index] = txtValorNuevo.Text;
			this.Close();
		}
		
		void CboNombreAtributosSelectedIndexChanged(object sender, EventArgs e)
		{
			int index = cboNombreAtributos.SelectedIndex;
			
			if (index == -1) return;
			
			txtViejoValor.Text = expresiones[index];
		}
	}
}
