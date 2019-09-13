/*
 * Created by SharpDevelop.
 * User: diego
 * Date: 13/04/2019
 * Time: 03:40 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ProyectoFinalMD
{
	/// <summary>
	/// Description of ModificarAtributo.
	/// </summary>
	public partial class ModificarAtributo : Form
	{
		List<string> items = new List<string>();
		int posicion;
		
		public ModificarAtributo(List<string> _items)
		{
			InitializeComponent();
			items = _items;
			foreach (string item in items) 
			{
				cboNombreAtributos.Items.Add(item);
			}
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			string valor = cboNombreAtributos.SelectedItem.ToString();
			string nuevo = txtNuevoNombre.Text;
			
			if (string.IsNullOrEmpty(nuevo) || string.IsNullOrEmpty(valor)) return;
			
			for (int i = 0; i < items.Count; i++) 
			{
				if (items[i] == valor)
				{
					items.RemoveAt(i);
					posicion = i;
					items.Insert(i, nuevo);
					break;
				}
			}
			this.Close();
		}
		
		public List<string> obtenerLista() {
			return items;
			}
		
		public int obtenerPosicion() {
			return posicion;
			}
	}
}
