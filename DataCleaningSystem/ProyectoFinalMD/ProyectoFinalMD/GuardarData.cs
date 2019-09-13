using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ProyectoFinalMD
{
	/// <summary>
	/// Description of GuardarData.
	/// </summary>
	public partial class GuardarData : Form
	{
		List<string> tipo = new List<string>();
		List<string> expresiones = new List<string>();
		string relacion;
		string comentarios;
		string faltante;
		
		public GuardarData(List<string> atributos)
		{
			InitializeComponent();
			
			for (int i = 0; i < atributos.Count; i++) 
			{
				dgvAtributos.Rows.Add(1);
				dgvAtributos.Rows[i].Cells[0].Value = atributos[i];
			}
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			string tip, expresion;
			comentarios = txtComentarios.Text;
			relacion = txtRelacion.Text;
			faltante = txtFaltante.Text;
			for (int i = 0; i < dgvAtributos.RowCount - 1; i++)
			{
				try
				{
					tip = dgvAtributos.Rows[i].Cells[1].Value.ToString();
					expresion = dgvAtributos.Rows[i].Cells[2].Value.ToString();
				}
				catch
				{
					tip = "categoric";
					expresion = "\\w+";
				}
				
				tipo.Add(tip);
				expresiones.Add(expresion);
			}
			
			this.Close();
		}
		
		public string obtenerRelacion()
		{
			return relacion;
		}
		
		public string obtenerComentarios()
		{
			return comentarios;
		}
		
		public List<string> obtenerTipo()
		{
			return tipo;
		}
		
		public List<string> obtenerExpresiones()
		{			
			return expresiones;
		}
		
		public string obtenerFaltante()
		{
			return faltante;
		}
	}
}
