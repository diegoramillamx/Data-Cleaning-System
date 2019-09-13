/*
 * Created by SharpDevelop.
 * User: diego
 * Date: 06/05/2019
 * Time: 02:37 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoFinalMD
{
	partial class GuardarData
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox gbComentarios;
		private System.Windows.Forms.TextBox txtComentarios;
		private System.Windows.Forms.TextBox txtRelacion;
		private System.Windows.Forms.Label lblRelacion;
		private System.Windows.Forms.DataGridView dgvAtributos;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombreAtributo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn ExpresionRegular;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Label lblFaltante;
		private System.Windows.Forms.TextBox txtFaltante;
		
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
			this.gbComentarios = new System.Windows.Forms.GroupBox();
			this.txtComentarios = new System.Windows.Forms.TextBox();
			this.txtRelacion = new System.Windows.Forms.TextBox();
			this.lblRelacion = new System.Windows.Forms.Label();
			this.dgvAtributos = new System.Windows.Forms.DataGridView();
			this.NombreAtributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExpresionRegular = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.lblFaltante = new System.Windows.Forms.Label();
			this.txtFaltante = new System.Windows.Forms.TextBox();
			this.gbComentarios.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAtributos)).BeginInit();
			this.SuspendLayout();
			// 
			// gbComentarios
			// 
			this.gbComentarios.Controls.Add(this.txtComentarios);
			this.gbComentarios.Location = new System.Drawing.Point(12, 12);
			this.gbComentarios.Name = "gbComentarios";
			this.gbComentarios.Size = new System.Drawing.Size(1169, 178);
			this.gbComentarios.TabIndex = 0;
			this.gbComentarios.TabStop = false;
			this.gbComentarios.Text = "Comentarios en el archivo";
			// 
			// txtComentarios
			// 
			this.txtComentarios.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtComentarios.Location = new System.Drawing.Point(6, 30);
			this.txtComentarios.Multiline = true;
			this.txtComentarios.Name = "txtComentarios";
			this.txtComentarios.Size = new System.Drawing.Size(1157, 133);
			this.txtComentarios.TabIndex = 0;
			// 
			// txtRelacion
			// 
			this.txtRelacion.Location = new System.Drawing.Point(207, 217);
			this.txtRelacion.Name = "txtRelacion";
			this.txtRelacion.Size = new System.Drawing.Size(313, 22);
			this.txtRelacion.TabIndex = 1;
			// 
			// lblRelacion
			// 
			this.lblRelacion.AutoSize = true;
			this.lblRelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRelacion.Location = new System.Drawing.Point(14, 220);
			this.lblRelacion.Name = "lblRelacion";
			this.lblRelacion.Size = new System.Drawing.Size(173, 17);
			this.lblRelacion.TabIndex = 2;
			this.lblRelacion.Text = "Nombre de la relación:";
			// 
			// dgvAtributos
			// 
			this.dgvAtributos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAtributos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAtributos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.NombreAtributo,
			this.Tipo,
			this.ExpresionRegular});
			this.dgvAtributos.Location = new System.Drawing.Point(12, 274);
			this.dgvAtributos.Name = "dgvAtributos";
			this.dgvAtributos.RowTemplate.Height = 24;
			this.dgvAtributos.Size = new System.Drawing.Size(1169, 338);
			this.dgvAtributos.TabIndex = 3;
			// 
			// NombreAtributo
			// 
			this.NombreAtributo.HeaderText = "Nombre del atributo";
			this.NombreAtributo.Name = "NombreAtributo";
			// 
			// Tipo
			// 
			this.Tipo.HeaderText = "Tipo de dato";
			this.Tipo.Name = "Tipo";
			// 
			// ExpresionRegular
			// 
			this.ExpresionRegular.HeaderText = "Expresión regular del atributo";
			this.ExpresionRegular.Name = "ExpresionRegular";
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(960, 629);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(215, 60);
			this.btnAceptar.TabIndex = 4;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// lblFaltante
			// 
			this.lblFaltante.AutoSize = true;
			this.lblFaltante.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFaltante.Location = new System.Drawing.Point(607, 220);
			this.lblFaltante.Name = "lblFaltante";
			this.lblFaltante.Size = new System.Drawing.Size(111, 17);
			this.lblFaltante.TabIndex = 6;
			this.lblFaltante.Text = "Valor faltante:";
			// 
			// txtFaltante
			// 
			this.txtFaltante.Location = new System.Drawing.Point(738, 217);
			this.txtFaltante.Name = "txtFaltante";
			this.txtFaltante.Size = new System.Drawing.Size(313, 22);
			this.txtFaltante.TabIndex = 5;
			// 
			// GuardarData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1193, 713);
			this.Controls.Add(this.lblFaltante);
			this.Controls.Add(this.txtFaltante);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.dgvAtributos);
			this.Controls.Add(this.lblRelacion);
			this.Controls.Add(this.txtRelacion);
			this.Controls.Add(this.gbComentarios);
			this.Name = "GuardarData";
			this.Text = "GuardarData";
			this.gbComentarios.ResumeLayout(false);
			this.gbComentarios.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAtributos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
