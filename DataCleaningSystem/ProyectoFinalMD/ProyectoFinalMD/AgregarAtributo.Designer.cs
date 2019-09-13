/*
 * Created by SharpDevelop.
 * User: diego
 * Date: 13/04/2019
 * Time: 03:16 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoFinalMD
{
	partial class AgregarAtributo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtValorAtributo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombreAtributo;
		private System.Windows.Forms.Label lblAtributo;
		private System.Windows.Forms.Button btnAceptar;
		
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.txtValorAtributo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombreAtributo = new System.Windows.Forms.TextBox();
			this.lblAtributo = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnAceptar);
			this.groupBox1.Controls.Add(this.txtValorAtributo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtNombreAtributo);
			this.groupBox1.Controls.Add(this.lblAtributo);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(519, 237);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Agregar atributo:";
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(155, 130);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(200, 68);
			this.btnAceptar.TabIndex = 4;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// txtValorAtributo
			// 
			this.txtValorAtributo.Location = new System.Drawing.Point(223, 79);
			this.txtValorAtributo.Name = "txtValorAtributo";
			this.txtValorAtributo.Size = new System.Drawing.Size(257, 22);
			this.txtValorAtributo.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Valor por defecto:";
			// 
			// txtNombreAtributo
			// 
			this.txtNombreAtributo.Location = new System.Drawing.Point(223, 51);
			this.txtNombreAtributo.Name = "txtNombreAtributo";
			this.txtNombreAtributo.Size = new System.Drawing.Size(257, 22);
			this.txtNombreAtributo.TabIndex = 1;
			// 
			// lblAtributo
			// 
			this.lblAtributo.AutoSize = true;
			this.lblAtributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAtributo.Location = new System.Drawing.Point(15, 51);
			this.lblAtributo.Name = "lblAtributo";
			this.lblAtributo.Size = new System.Drawing.Size(181, 20);
			this.lblAtributo.TabIndex = 0;
			this.lblAtributo.Text = "Nombre del atributo:";
			// 
			// AgregarAtributo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(540, 261);
			this.Controls.Add(this.groupBox1);
			this.Name = "AgregarAtributo";
			this.Text = "AgregarAtributo";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
