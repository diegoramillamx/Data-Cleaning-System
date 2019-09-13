using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ProyectoFinalMD {
	
	public partial class ErroresGramatica : Form {
	
		private List<string> valores = new List<string>();
		
		public ErroresGramatica() {
			InitializeComponent();
			}
		
		void BtnAceptarClick(object sender, EventArgs e) {
			string valor = txtNuevoValor.Text.ToUpper();
			if (!string.IsNullOrEmpty(valor)) {
				valores.Add(valor);
				lsvValores.Items.Add(valor);
				}
			
			txtNuevoValor.Clear();
			txtNuevoValor.Focus();
			}
		
		void BtnSalirClick(object sender, EventArgs e) {
			this.Close();
			}
		
		public List<string> obtenerLista() {
			return valores;
			}
		}
	}
