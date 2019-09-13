/*
 * Created by SharpDevelop.
 * User: diego
 * Date: 06/05/2019
 * Time: 12:13 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoFinalMD
{
	partial class MaximoMinimo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown nupNuevoMinimo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown nupNuevoMaximo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nupMinimo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nupMaximo;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Label lblMaximo;
		
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
			this.nupNuevoMinimo = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.nupNuevoMaximo = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.nupMinimo = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.nupMaximo = new System.Windows.Forms.NumericUpDown();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.lblMaximo = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nupNuevoMinimo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nupNuevoMaximo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nupMinimo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nupMaximo)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.nupNuevoMinimo);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.nupNuevoMaximo);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.nupMinimo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.nupMaximo);
			this.groupBox1.Controls.Add(this.btnAceptar);
			this.groupBox1.Controls.Add(this.lblMaximo);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(324, 315);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Máximo y mínimo";
			// 
			// nupNuevoMinimo
			// 
			this.nupNuevoMinimo.Increment = new decimal(new int[] {
			10,
			0,
			0,
			0});
			this.nupNuevoMinimo.Location = new System.Drawing.Point(195, 180);
			this.nupNuevoMinimo.Maximum = new decimal(new int[] {
			500,
			0,
			0,
			0});
			this.nupNuevoMinimo.Name = "nupNuevoMinimo";
			this.nupNuevoMinimo.Size = new System.Drawing.Size(110, 22);
			this.nupNuevoMinimo.TabIndex = 11;
			this.nupNuevoMinimo.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(15, 179);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(127, 20);
			this.label3.TabIndex = 10;
			this.label3.Text = "Nuevo mínimo";
			// 
			// nupNuevoMaximo
			// 
			this.nupNuevoMaximo.Increment = new decimal(new int[] {
			10,
			0,
			0,
			0});
			this.nupNuevoMaximo.Location = new System.Drawing.Point(195, 137);
			this.nupNuevoMaximo.Maximum = new decimal(new int[] {
			500,
			0,
			0,
			0});
			this.nupNuevoMaximo.Name = "nupNuevoMaximo";
			this.nupNuevoMaximo.Size = new System.Drawing.Size(110, 22);
			this.nupNuevoMaximo.TabIndex = 9;
			this.nupNuevoMaximo.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(15, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "Nuevo máximo";
			// 
			// nupMinimo
			// 
			this.nupMinimo.Increment = new decimal(new int[] {
			10,
			0,
			0,
			0});
			this.nupMinimo.Location = new System.Drawing.Point(158, 94);
			this.nupMinimo.Maximum = new decimal(new int[] {
			500,
			0,
			0,
			0});
			this.nupMinimo.Name = "nupMinimo";
			this.nupMinimo.Size = new System.Drawing.Size(147, 22);
			this.nupMinimo.TabIndex = 7;
			this.nupMinimo.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Mínimo";
			// 
			// nupMaximo
			// 
			this.nupMaximo.Increment = new decimal(new int[] {
			10,
			0,
			0,
			0});
			this.nupMaximo.Location = new System.Drawing.Point(158, 52);
			this.nupMaximo.Maximum = new decimal(new int[] {
			500,
			0,
			0,
			0});
			this.nupMaximo.Name = "nupMaximo";
			this.nupMaximo.Size = new System.Drawing.Size(147, 22);
			this.nupMaximo.TabIndex = 5;
			this.nupMaximo.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(44, 225);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(200, 68);
			this.btnAceptar.TabIndex = 4;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// lblMaximo
			// 
			this.lblMaximo.AutoSize = true;
			this.lblMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMaximo.Location = new System.Drawing.Point(15, 51);
			this.lblMaximo.Name = "lblMaximo";
			this.lblMaximo.Size = new System.Drawing.Size(73, 20);
			this.lblMaximo.TabIndex = 0;
			this.lblMaximo.Text = "Máximo";
			// 
			// MaximoMinimo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 337);
			this.Controls.Add(this.groupBox1);
			this.Name = "MaximoMinimo";
			this.Text = "MaximoMinimo";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nupNuevoMinimo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nupNuevoMaximo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nupMinimo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nupMaximo)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
