/*
 * Created by SharpDevelop.
 * User: diego
 * Date: 01/05/2019
 * Time: 07:07 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoFinalMD
{
	partial class ErroresGramatica
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox gboErrores;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.TextBox txtNuevoValor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView lsvValores;
		private System.Windows.Forms.Button btnSalir;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.gboErrores = new System.Windows.Forms.GroupBox();
			this.lsvValores = new System.Windows.Forms.ListView();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.txtNuevoValor = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gboErrores.SuspendLayout();
			this.SuspendLayout();
			// 
			// gboErrores
			// 
			this.gboErrores.Controls.Add(this.lsvValores);
			this.gboErrores.Controls.Add(this.btnSalir);
			this.gboErrores.Controls.Add(this.btnAceptar);
			this.gboErrores.Controls.Add(this.txtNuevoValor);
			this.gboErrores.Controls.Add(this.label1);
			this.gboErrores.Location = new System.Drawing.Point(12, 12);
			this.gboErrores.Name = "gboErrores";
			this.gboErrores.Size = new System.Drawing.Size(519, 237);
			this.gboErrores.TabIndex = 2;
			this.gboErrores.TabStop = false;
			this.gboErrores.Text = "Dominio del atributo";
			// 
			// lsvValores
			// 
			this.lsvValores.Location = new System.Drawing.Point(354, 21);
			this.lsvValores.Name = "lsvValores";
			this.lsvValores.Size = new System.Drawing.Size(141, 180);
			this.lsvValores.TabIndex = 6;
			this.lsvValores.UseCompatibleStateImageBehavior = false;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(183, 101);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(141, 68);
			this.btnSalir.TabIndex = 5;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(17, 101);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(141, 68);
			this.btnAceptar.TabIndex = 4;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// txtNuevoValor
			// 
			this.txtNuevoValor.Location = new System.Drawing.Point(148, 51);
			this.txtNuevoValor.Name = "txtNuevoValor";
			this.txtNuevoValor.Size = new System.Drawing.Size(176, 22);
			this.txtNuevoValor.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(17, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nuevo valor:";
			// 
			// ErroresGramatica
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 266);
			this.Controls.Add(this.gboErrores);
			this.Name = "ErroresGramatica";
			this.Text = "ErroresGramatica";
			this.gboErrores.ResumeLayout(false);
			this.gboErrores.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
