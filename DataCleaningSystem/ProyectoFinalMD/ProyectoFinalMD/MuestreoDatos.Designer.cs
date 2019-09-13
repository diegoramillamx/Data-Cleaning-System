/*
 * Created by SharpDevelop.
 * User: diego
 * Date: 06/05/2019
 * Time: 01:05 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoFinalMD
{
	partial class MuestreoDatos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown nupInstancias;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Label lblAtributo;
		
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
			this.nupInstancias = new System.Windows.Forms.NumericUpDown();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.lblAtributo = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nupInstancias)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.nupInstancias);
			this.groupBox1.Controls.Add(this.btnAceptar);
			this.groupBox1.Controls.Add(this.lblAtributo);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(519, 206);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Muestreo de datos";
			// 
			// nupInstancias
			// 
			this.nupInstancias.Increment = new decimal(new int[] {
			100,
			0,
			0,
			0});
			this.nupInstancias.Location = new System.Drawing.Point(366, 49);
			this.nupInstancias.Name = "nupInstancias";
			this.nupInstancias.Size = new System.Drawing.Size(147, 22);
			this.nupInstancias.TabIndex = 5;
			this.nupInstancias.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(155, 100);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(200, 68);
			this.btnAceptar.TabIndex = 4;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// lblAtributo
			// 
			this.lblAtributo.AutoSize = true;
			this.lblAtributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAtributo.Location = new System.Drawing.Point(15, 51);
			this.lblAtributo.Name = "lblAtributo";
			this.lblAtributo.Size = new System.Drawing.Size(282, 20);
			this.lblAtributo.TabIndex = 0;
			this.lblAtributo.Text = "Indique el número de instancias:";
			// 
			// MuestreoDatos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(547, 235);
			this.Controls.Add(this.groupBox1);
			this.Name = "MuestreoDatos";
			this.Text = "MuestreoDatos";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nupInstancias)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
