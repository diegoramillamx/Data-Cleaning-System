/*
 * Created by SharpDevelop.
 * User: diego
 * Date: 13/04/2019
 * Time: 03:16 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinalMD
{
	/// <summary>
	/// Description of AgregarAtributo.
	/// </summary>
	public partial class AgregarAtributo : Form
	{
		private string nombreAtributo, valorAtributo;
		public AgregarAtributo()
		{
			InitializeComponent();
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			if (txtNombreAtributo.Text == string.Empty || txtNombreAtributo.Text == string.Empty) {
				MessageBox.Show("Alguno de los valores está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
				}
			
			nombreAtributo = txtNombreAtributo.Text;
			valorAtributo = txtValorAtributo.Text;
			this.Close();
		}
		
		public string obtenerNombre() {
			return nombreAtributo;
			}
		
		public string obtenerValor() {
			return valorAtributo;
			}
	}
}
