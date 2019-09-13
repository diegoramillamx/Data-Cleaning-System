/*
 * Created by SharpDevelop.
 * User: diego
 * Date: 12/04/2019
 * Time: 10:40 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoFinalMD
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.TabControl tbPrincipal;
		private System.Windows.Forms.TabPage tbDatos;
		private System.Windows.Forms.TabPage tabAnalisisUnivariable;
		private System.Windows.Forms.Label lblProporcion;
		private System.Windows.Forms.Label lblValores;
		private System.Windows.Forms.Label lblAtributos;
		private System.Windows.Forms.Label lblInstancias;
		private System.Windows.Forms.Label lblNombreArchivo;
		private System.Windows.Forms.Button btneliminarinstancia;
		private System.Windows.Forms.ComboBox cbxeliminaratributo;
		private System.Windows.Forms.Button btneliminaratributo;
		private System.Windows.Forms.Label lbleliminaratributo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnAgregarAtributo;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cboAnalisisAtributo;
		private System.Windows.Forms.Label lblProporcionAtributos;
		private System.Windows.Forms.Label lblFaltantesAtributo;
		private System.Windows.Forms.DataGridView dgvDatoEstadisticos;
		private System.Windows.Forms.Label lblmediana;
		private System.Windows.Forms.Label lblmoda;
		private System.Windows.Forms.Label lblmedia;
		private System.Windows.Forms.ComboBox cbxdatosnumericos;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dgvFrecuencia;
		private System.Windows.Forms.Label lblDesviacion;
		private System.Windows.Forms.TabPage AnalisisBivariable;
		private System.Windows.Forms.Button btnCorrelacion;
		private System.Windows.Forms.ComboBox cboBivariable2;
		private System.Windows.Forms.ComboBox cboBivariable1;
		private System.Windows.Forms.DataGridView dgvBivariable;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label lblCoeficienteCorrelacion;
		private System.Windows.Forms.DataVisualization.Charting.Chart BoxPlot;
		private System.Windows.Forms.DataGridView dgvContingencia;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label lblContingencia;
		private System.Windows.Forms.Label lblChiCuadrada;
		private System.Windows.Forms.TabPage tbLimpieza;
		private System.Windows.Forms.GroupBox gbLimpieza1;
		private System.Windows.Forms.Button btnAnalisisLlenado;
		private System.Windows.Forms.ComboBox cboLlenadoDatos;
		private System.Windows.Forms.Button btnLlenar;
		private System.Windows.Forms.Label lblRecomendacion;
		private System.Windows.Forms.RadioButton rdbMediana;
		private System.Windows.Forms.RadioButton rdbMedia;
		private System.Windows.Forms.GroupBox gbTransformacion;
		private System.Windows.Forms.RadioButton rdbz_scoreabsoluta;
		private System.Windows.Forms.RadioButton rdbz_score;
		private System.Windows.Forms.RadioButton rdbmin_max;
		private System.Windows.Forms.ComboBox cbxtransformacion;
		private System.Windows.Forms.Button btnTransformar;
		private System.Windows.Forms.RadioButton rdbModa;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.ComboBox cboOutliers;
		private System.Windows.Forms.Label lblRecomendacionOutliers;
		private System.Windows.Forms.Button btnAnalisisOutlier;
		private System.Windows.Forms.RadioButton rdbMediaOutlier;
		private System.Windows.Forms.Button btnReemplazarOutliers;
		private System.Windows.Forms.RadioButton rdbMedianaOutlier;
		private ZedGraph.ZedGraphControl Dispersion;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDetectarErrores;
		private System.Windows.Forms.ComboBox cboErroresTipograficos;
		private System.Windows.Forms.ProgressBar psbLimpieza;
		private System.Windows.Forms.DataGridView dgvDatos;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.Button btnMuestreo;
		private System.Windows.Forms.RadioButton rdbMuestroSinReemplazo;
		private System.Windows.Forms.RadioButton rdbMuestroReemplazo;
		private System.Windows.Forms.Label lblTipoDato;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.Button btnBuscarReemplazar;
		private System.Windows.Forms.ProgressBar pdbDatos;
		private System.Windows.Forms.Button btnModificarExpresion;
	
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tbPrincipal = new System.Windows.Forms.TabControl();
			this.tbDatos = new System.Windows.Forms.TabPage();
			this.btnModificarExpresion = new System.Windows.Forms.Button();
			this.pdbDatos = new System.Windows.Forms.ProgressBar();
			this.dgvDatos = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblTipoDato = new System.Windows.Forms.Label();
			this.cboAnalisisAtributo = new System.Windows.Forms.ComboBox();
			this.lblProporcionAtributos = new System.Windows.Forms.Label();
			this.lblFaltantesAtributo = new System.Windows.Forms.Label();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnAgregarAtributo = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblNombreArchivo = new System.Windows.Forms.Label();
			this.lblInstancias = new System.Windows.Forms.Label();
			this.lblAtributos = new System.Windows.Forms.Label();
			this.lblValores = new System.Windows.Forms.Label();
			this.lblProporcion = new System.Windows.Forms.Label();
			this.lbleliminaratributo = new System.Windows.Forms.Label();
			this.btneliminaratributo = new System.Windows.Forms.Button();
			this.cbxeliminaratributo = new System.Windows.Forms.ComboBox();
			this.btneliminarinstancia = new System.Windows.Forms.Button();
			this.tabAnalisisUnivariable = new System.Windows.Forms.TabPage();
			this.BoxPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.dgvFrecuencia = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lblDesviacion = new System.Windows.Forms.Label();
			this.lblmedia = new System.Windows.Forms.Label();
			this.lblmoda = new System.Windows.Forms.Label();
			this.lblmediana = new System.Windows.Forms.Label();
			this.cbxdatosnumericos = new System.Windows.Forms.ComboBox();
			this.dgvDatoEstadisticos = new System.Windows.Forms.DataGridView();
			this.AnalisisBivariable = new System.Windows.Forms.TabPage();
			this.Dispersion = new ZedGraph.ZedGraphControl();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.lblContingencia = new System.Windows.Forms.Label();
			this.lblChiCuadrada = new System.Windows.Forms.Label();
			this.dgvContingencia = new System.Windows.Forms.DataGridView();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.lblCoeficienteCorrelacion = new System.Windows.Forms.Label();
			this.btnCorrelacion = new System.Windows.Forms.Button();
			this.cboBivariable2 = new System.Windows.Forms.ComboBox();
			this.cboBivariable1 = new System.Windows.Forms.ComboBox();
			this.dgvBivariable = new System.Windows.Forms.DataGridView();
			this.tbLimpieza = new System.Windows.Forms.TabPage();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.btnBuscarReemplazar = new System.Windows.Forms.Button();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.btnMuestreo = new System.Windows.Forms.Button();
			this.rdbMuestroSinReemplazo = new System.Windows.Forms.RadioButton();
			this.rdbMuestroReemplazo = new System.Windows.Forms.RadioButton();
			this.psbLimpieza = new System.Windows.Forms.ProgressBar();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnDetectarErrores = new System.Windows.Forms.Button();
			this.cboErroresTipograficos = new System.Windows.Forms.ComboBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.btnReemplazarOutliers = new System.Windows.Forms.Button();
			this.rdbMedianaOutlier = new System.Windows.Forms.RadioButton();
			this.rdbMediaOutlier = new System.Windows.Forms.RadioButton();
			this.lblRecomendacionOutliers = new System.Windows.Forms.Label();
			this.btnAnalisisOutlier = new System.Windows.Forms.Button();
			this.cboOutliers = new System.Windows.Forms.ComboBox();
			this.gbTransformacion = new System.Windows.Forms.GroupBox();
			this.btnTransformar = new System.Windows.Forms.Button();
			this.rdbz_scoreabsoluta = new System.Windows.Forms.RadioButton();
			this.rdbz_score = new System.Windows.Forms.RadioButton();
			this.rdbmin_max = new System.Windows.Forms.RadioButton();
			this.cbxtransformacion = new System.Windows.Forms.ComboBox();
			this.gbLimpieza1 = new System.Windows.Forms.GroupBox();
			this.rdbModa = new System.Windows.Forms.RadioButton();
			this.btnLlenar = new System.Windows.Forms.Button();
			this.lblRecomendacion = new System.Windows.Forms.Label();
			this.rdbMediana = new System.Windows.Forms.RadioButton();
			this.rdbMedia = new System.Windows.Forms.RadioButton();
			this.btnAnalisisLlenado = new System.Windows.Forms.Button();
			this.cboLlenadoDatos = new System.Windows.Forms.ComboBox();
			this.menuStrip1.SuspendLayout();
			this.tbPrincipal.SuspendLayout();
			this.tbDatos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabAnalisisUnivariable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BoxPlot)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencia)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatoEstadisticos)).BeginInit();
			this.AnalisisBivariable.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvContingencia)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBivariable)).BeginInit();
			this.tbLimpieza.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.gbTransformacion.SuspendLayout();
			this.gbLimpieza1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.archivoToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1825, 25);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.abrirToolStripMenuItem,
			this.guardarToolStripMenuItem,
			this.guardarComoToolStripMenuItem,
			this.salirToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// abrirToolStripMenuItem
			// 
			this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
			this.abrirToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
			this.abrirToolStripMenuItem.Text = "Abrir";
			this.abrirToolStripMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItemClick);
			// 
			// guardarToolStripMenuItem
			// 
			this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
			this.guardarToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
			this.guardarToolStripMenuItem.Text = "Guardar";
			this.guardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItemClick);
			// 
			// guardarComoToolStripMenuItem
			// 
			this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
			this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
			this.guardarComoToolStripMenuItem.Text = "Guardar como";
			this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.GuardarComoToolStripMenuItemClick);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// tbPrincipal
			// 
			this.tbPrincipal.Controls.Add(this.tbDatos);
			this.tbPrincipal.Controls.Add(this.tabAnalisisUnivariable);
			this.tbPrincipal.Controls.Add(this.AnalisisBivariable);
			this.tbPrincipal.Controls.Add(this.tbLimpieza);
			this.tbPrincipal.Location = new System.Drawing.Point(12, 28);
			this.tbPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbPrincipal.Name = "tbPrincipal";
			this.tbPrincipal.SelectedIndex = 0;
			this.tbPrincipal.Size = new System.Drawing.Size(1801, 724);
			this.tbPrincipal.TabIndex = 1;
			// 
			// tbDatos
			// 
			this.tbDatos.Controls.Add(this.btnModificarExpresion);
			this.tbDatos.Controls.Add(this.pdbDatos);
			this.tbDatos.Controls.Add(this.dgvDatos);
			this.tbDatos.Controls.Add(this.groupBox2);
			this.tbDatos.Controls.Add(this.btnModificar);
			this.tbDatos.Controls.Add(this.btnAgregarAtributo);
			this.tbDatos.Controls.Add(this.groupBox1);
			this.tbDatos.Controls.Add(this.lbleliminaratributo);
			this.tbDatos.Controls.Add(this.btneliminaratributo);
			this.tbDatos.Controls.Add(this.cbxeliminaratributo);
			this.tbDatos.Controls.Add(this.btneliminarinstancia);
			this.tbDatos.Location = new System.Drawing.Point(4, 25);
			this.tbDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbDatos.Name = "tbDatos";
			this.tbDatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbDatos.Size = new System.Drawing.Size(1793, 695);
			this.tbDatos.TabIndex = 0;
			this.tbDatos.Text = "Visualizar datos";
			this.tbDatos.UseVisualStyleBackColor = true;
			// 
			// btnModificarExpresion
			// 
			this.btnModificarExpresion.Enabled = false;
			this.btnModificarExpresion.Location = new System.Drawing.Point(1475, 212);
			this.btnModificarExpresion.Margin = new System.Windows.Forms.Padding(4);
			this.btnModificarExpresion.Name = "btnModificarExpresion";
			this.btnModificarExpresion.Size = new System.Drawing.Size(312, 28);
			this.btnModificarExpresion.TabIndex = 16;
			this.btnModificarExpresion.Text = "Modificar expresión regular";
			this.btnModificarExpresion.UseVisualStyleBackColor = true;
			this.btnModificarExpresion.Click += new System.EventHandler(this.BtnModificarExpresionClick);
			// 
			// pdbDatos
			// 
			this.pdbDatos.Location = new System.Drawing.Point(1475, 606);
			this.pdbDatos.Name = "pdbDatos";
			this.pdbDatos.Size = new System.Drawing.Size(304, 23);
			this.pdbDatos.TabIndex = 15;
			// 
			// dgvDatos
			// 
			this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDatos.Location = new System.Drawing.Point(249, 11);
			this.dgvDatos.Name = "dgvDatos";
			this.dgvDatos.RowTemplate.Height = 24;
			this.dgvDatos.Size = new System.Drawing.Size(1220, 674);
			this.dgvDatos.TabIndex = 14;
			this.dgvDatos.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDatosCellLeave);
			this.dgvDatos.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.DgvDatosDefaultValuesNeeded);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblTipoDato);
			this.groupBox2.Controls.Add(this.cboAnalisisAtributo);
			this.groupBox2.Controls.Add(this.lblProporcionAtributos);
			this.groupBox2.Controls.Add(this.lblFaltantesAtributo);
			this.groupBox2.Location = new System.Drawing.Point(1475, 11);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(312, 177);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Estádisticas por atributo";
			// 
			// lblTipoDato
			// 
			this.lblTipoDato.AutoSize = true;
			this.lblTipoDato.Location = new System.Drawing.Point(7, 139);
			this.lblTipoDato.Name = "lblTipoDato";
			this.lblTipoDato.Size = new System.Drawing.Size(92, 17);
			this.lblTipoDato.TabIndex = 15;
			this.lblTipoDato.Text = "Tipo de dato:";
			// 
			// cboAnalisisAtributo
			// 
			this.cboAnalisisAtributo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboAnalisisAtributo.FormattingEnabled = true;
			this.cboAnalisisAtributo.Location = new System.Drawing.Point(7, 22);
			this.cboAnalisisAtributo.Margin = new System.Windows.Forms.Padding(4);
			this.cboAnalisisAtributo.Name = "cboAnalisisAtributo";
			this.cboAnalisisAtributo.Size = new System.Drawing.Size(297, 24);
			this.cboAnalisisAtributo.TabIndex = 14;
			this.cboAnalisisAtributo.SelectedIndexChanged += new System.EventHandler(this.CboAnalisisAtributoSelectedIndexChanged);
			// 
			// lblProporcionAtributos
			// 
			this.lblProporcionAtributos.AutoSize = true;
			this.lblProporcionAtributos.Location = new System.Drawing.Point(5, 103);
			this.lblProporcionAtributos.Name = "lblProporcionAtributos";
			this.lblProporcionAtributos.Size = new System.Drawing.Size(81, 17);
			this.lblProporcionAtributos.TabIndex = 9;
			this.lblProporcionAtributos.Text = "Proporción:";
			// 
			// lblFaltantesAtributo
			// 
			this.lblFaltantesAtributo.AutoSize = true;
			this.lblFaltantesAtributo.Location = new System.Drawing.Point(5, 68);
			this.lblFaltantesAtributo.Name = "lblFaltantesAtributo";
			this.lblFaltantesAtributo.Size = new System.Drawing.Size(118, 17);
			this.lblFaltantesAtributo.TabIndex = 8;
			this.lblFaltantesAtributo.Text = "Valores faltantes:";
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(5, 316);
			this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(237, 28);
			this.btnModificar.TabIndex = 12;
			this.btnModificar.Text = "Modificar atributo";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// btnAgregarAtributo
			// 
			this.btnAgregarAtributo.Location = new System.Drawing.Point(5, 281);
			this.btnAgregarAtributo.Margin = new System.Windows.Forms.Padding(4);
			this.btnAgregarAtributo.Name = "btnAgregarAtributo";
			this.btnAgregarAtributo.Size = new System.Drawing.Size(237, 28);
			this.btnAgregarAtributo.TabIndex = 11;
			this.btnAgregarAtributo.Text = "Agregar atributo";
			this.btnAgregarAtributo.UseVisualStyleBackColor = true;
			this.btnAgregarAtributo.Click += new System.EventHandler(this.BtnAgregarAtributoClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblNombreArchivo);
			this.groupBox1.Controls.Add(this.lblInstancias);
			this.groupBox1.Controls.Add(this.lblAtributos);
			this.groupBox1.Controls.Add(this.lblValores);
			this.groupBox1.Controls.Add(this.lblProporcion);
			this.groupBox1.Location = new System.Drawing.Point(8, 5);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(235, 263);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Información:";
			// 
			// lblNombreArchivo
			// 
			this.lblNombreArchivo.AutoSize = true;
			this.lblNombreArchivo.Location = new System.Drawing.Point(5, 28);
			this.lblNombreArchivo.Name = "lblNombreArchivo";
			this.lblNombreArchivo.Size = new System.Drawing.Size(62, 17);
			this.lblNombreArchivo.TabIndex = 1;
			this.lblNombreArchivo.Text = "Nombre:";
			// 
			// lblInstancias
			// 
			this.lblInstancias.AutoSize = true;
			this.lblInstancias.Location = new System.Drawing.Point(5, 74);
			this.lblInstancias.Name = "lblInstancias";
			this.lblInstancias.Size = new System.Drawing.Size(149, 17);
			this.lblInstancias.TabIndex = 2;
			this.lblInstancias.Text = "Número de instancias:";
			// 
			// lblAtributos
			// 
			this.lblAtributos.AutoSize = true;
			this.lblAtributos.Location = new System.Drawing.Point(5, 126);
			this.lblAtributos.Name = "lblAtributos";
			this.lblAtributos.Size = new System.Drawing.Size(141, 17);
			this.lblAtributos.TabIndex = 3;
			this.lblAtributos.Text = "Número de atributos:";
			// 
			// lblValores
			// 
			this.lblValores.AutoSize = true;
			this.lblValores.Location = new System.Drawing.Point(5, 182);
			this.lblValores.Name = "lblValores";
			this.lblValores.Size = new System.Drawing.Size(118, 17);
			this.lblValores.TabIndex = 4;
			this.lblValores.Text = "Valores faltantes:";
			// 
			// lblProporcion
			// 
			this.lblProporcion.AutoSize = true;
			this.lblProporcion.Location = new System.Drawing.Point(5, 238);
			this.lblProporcion.Name = "lblProporcion";
			this.lblProporcion.Size = new System.Drawing.Size(81, 17);
			this.lblProporcion.TabIndex = 5;
			this.lblProporcion.Text = "Proporción:";
			// 
			// lbleliminaratributo
			// 
			this.lbleliminaratributo.Location = new System.Drawing.Point(9, 370);
			this.lbleliminaratributo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbleliminaratributo.Name = "lbleliminaratributo";
			this.lbleliminaratributo.Size = new System.Drawing.Size(208, 28);
			this.lbleliminaratributo.TabIndex = 9;
			this.lbleliminaratributo.Text = "Seleccione atributo a eliminar: ";
			// 
			// btneliminaratributo
			// 
			this.btneliminaratributo.Location = new System.Drawing.Point(5, 434);
			this.btneliminaratributo.Margin = new System.Windows.Forms.Padding(4);
			this.btneliminaratributo.Name = "btneliminaratributo";
			this.btneliminaratributo.Size = new System.Drawing.Size(237, 28);
			this.btneliminaratributo.TabIndex = 8;
			this.btneliminaratributo.Text = "Eliminar Atributo";
			this.btneliminaratributo.UseVisualStyleBackColor = true;
			this.btneliminaratributo.Click += new System.EventHandler(this.BtneliminaratributoClick);
			// 
			// cbxeliminaratributo
			// 
			this.cbxeliminaratributo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxeliminaratributo.FormattingEnabled = true;
			this.cbxeliminaratributo.Location = new System.Drawing.Point(5, 402);
			this.cbxeliminaratributo.Margin = new System.Windows.Forms.Padding(4);
			this.cbxeliminaratributo.Name = "cbxeliminaratributo";
			this.cbxeliminaratributo.Size = new System.Drawing.Size(236, 24);
			this.cbxeliminaratributo.TabIndex = 7;
			// 
			// btneliminarinstancia
			// 
			this.btneliminarinstancia.Location = new System.Drawing.Point(8, 471);
			this.btneliminarinstancia.Margin = new System.Windows.Forms.Padding(4);
			this.btneliminarinstancia.Name = "btneliminarinstancia";
			this.btneliminarinstancia.Size = new System.Drawing.Size(237, 28);
			this.btneliminarinstancia.TabIndex = 6;
			this.btneliminarinstancia.Text = "Eliminar Instancia";
			this.btneliminarinstancia.UseVisualStyleBackColor = true;
			this.btneliminarinstancia.Click += new System.EventHandler(this.BtneliminarinstanciaClick);
			// 
			// tabAnalisisUnivariable
			// 
			this.tabAnalisisUnivariable.Controls.Add(this.BoxPlot);
			this.tabAnalisisUnivariable.Controls.Add(this.dgvFrecuencia);
			this.tabAnalisisUnivariable.Controls.Add(this.groupBox3);
			this.tabAnalisisUnivariable.Controls.Add(this.cbxdatosnumericos);
			this.tabAnalisisUnivariable.Controls.Add(this.dgvDatoEstadisticos);
			this.tabAnalisisUnivariable.Location = new System.Drawing.Point(4, 25);
			this.tabAnalisisUnivariable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabAnalisisUnivariable.Name = "tabAnalisisUnivariable";
			this.tabAnalisisUnivariable.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabAnalisisUnivariable.Size = new System.Drawing.Size(1793, 695);
			this.tabAnalisisUnivariable.TabIndex = 1;
			this.tabAnalisisUnivariable.Text = "Análisis univariable";
			this.tabAnalisisUnivariable.UseVisualStyleBackColor = true;
			// 
			// BoxPlot
			// 
			chartArea1.Name = "ChartArea1";
			this.BoxPlot.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.BoxPlot.Legends.Add(legend1);
			this.BoxPlot.Location = new System.Drawing.Point(480, 250);
			this.BoxPlot.Margin = new System.Windows.Forms.Padding(4);
			this.BoxPlot.Name = "BoxPlot";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			series1.YValuesPerPoint = 6;
			this.BoxPlot.Series.Add(series1);
			this.BoxPlot.Size = new System.Drawing.Size(400, 369);
			this.BoxPlot.TabIndex = 8;
			this.BoxPlot.Text = "chart1";
			// 
			// dgvFrecuencia
			// 
			this.dgvFrecuencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvFrecuencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFrecuencia.Location = new System.Drawing.Point(888, 9);
			this.dgvFrecuencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvFrecuencia.Name = "dgvFrecuencia";
			this.dgvFrecuencia.RowTemplate.Height = 24;
			this.dgvFrecuencia.Size = new System.Drawing.Size(888, 219);
			this.dgvFrecuencia.TabIndex = 7;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lblDesviacion);
			this.groupBox3.Controls.Add(this.lblmedia);
			this.groupBox3.Controls.Add(this.lblmoda);
			this.groupBox3.Controls.Add(this.lblmediana);
			this.groupBox3.Location = new System.Drawing.Point(473, 39);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox3.Size = new System.Drawing.Size(383, 188);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Medidas de tendencia central";
			// 
			// lblDesviacion
			// 
			this.lblDesviacion.AutoSize = true;
			this.lblDesviacion.Location = new System.Drawing.Point(7, 123);
			this.lblDesviacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDesviacion.Name = "lblDesviacion";
			this.lblDesviacion.Size = new System.Drawing.Size(141, 17);
			this.lblDesviacion.TabIndex = 5;
			this.lblDesviacion.Text = "Desviación estándar:";
			// 
			// lblmedia
			// 
			this.lblmedia.AutoSize = true;
			this.lblmedia.Location = new System.Drawing.Point(7, 41);
			this.lblmedia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblmedia.Name = "lblmedia";
			this.lblmedia.Size = new System.Drawing.Size(46, 17);
			this.lblmedia.TabIndex = 2;
			this.lblmedia.Text = "Media";
			// 
			// lblmoda
			// 
			this.lblmoda.AutoSize = true;
			this.lblmoda.Location = new System.Drawing.Point(7, 69);
			this.lblmoda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblmoda.Name = "lblmoda";
			this.lblmoda.Size = new System.Drawing.Size(43, 17);
			this.lblmoda.TabIndex = 3;
			this.lblmoda.Text = "Moda";
			// 
			// lblmediana
			// 
			this.lblmediana.AutoSize = true;
			this.lblmediana.Location = new System.Drawing.Point(7, 97);
			this.lblmediana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblmediana.Name = "lblmediana";
			this.lblmediana.Size = new System.Drawing.Size(62, 17);
			this.lblmediana.TabIndex = 4;
			this.lblmediana.Text = "Mediana";
			// 
			// cbxdatosnumericos
			// 
			this.cbxdatosnumericos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxdatosnumericos.FormattingEnabled = true;
			this.cbxdatosnumericos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cbxdatosnumericos.Location = new System.Drawing.Point(473, 9);
			this.cbxdatosnumericos.Margin = new System.Windows.Forms.Padding(4);
			this.cbxdatosnumericos.Name = "cbxdatosnumericos";
			this.cbxdatosnumericos.Size = new System.Drawing.Size(383, 24);
			this.cbxdatosnumericos.TabIndex = 5;
			this.cbxdatosnumericos.SelectedIndexChanged += new System.EventHandler(this.CbxdatosnumericosSelectedIndexChanged);
			// 
			// dgvDatoEstadisticos
			// 
			this.dgvDatoEstadisticos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDatoEstadisticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDatoEstadisticos.Location = new System.Drawing.Point(5, 9);
			this.dgvDatoEstadisticos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvDatoEstadisticos.Name = "dgvDatoEstadisticos";
			this.dgvDatoEstadisticos.RowTemplate.Height = 24;
			this.dgvDatoEstadisticos.Size = new System.Drawing.Size(461, 677);
			this.dgvDatoEstadisticos.TabIndex = 1;
			// 
			// AnalisisBivariable
			// 
			this.AnalisisBivariable.Controls.Add(this.Dispersion);
			this.AnalisisBivariable.Controls.Add(this.groupBox5);
			this.AnalisisBivariable.Controls.Add(this.groupBox4);
			this.AnalisisBivariable.Controls.Add(this.btnCorrelacion);
			this.AnalisisBivariable.Controls.Add(this.cboBivariable2);
			this.AnalisisBivariable.Controls.Add(this.cboBivariable1);
			this.AnalisisBivariable.Controls.Add(this.dgvBivariable);
			this.AnalisisBivariable.Location = new System.Drawing.Point(4, 25);
			this.AnalisisBivariable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.AnalisisBivariable.Name = "AnalisisBivariable";
			this.AnalisisBivariable.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.AnalisisBivariable.Size = new System.Drawing.Size(1793, 695);
			this.AnalisisBivariable.TabIndex = 2;
			this.AnalisisBivariable.Text = "Análisis bivariable";
			this.AnalisisBivariable.UseVisualStyleBackColor = true;
			// 
			// Dispersion
			// 
			this.Dispersion.Location = new System.Drawing.Point(475, 158);
			this.Dispersion.Margin = new System.Windows.Forms.Padding(5);
			this.Dispersion.Name = "Dispersion";
			this.Dispersion.ScrollGrace = 0D;
			this.Dispersion.ScrollMaxX = 0D;
			this.Dispersion.ScrollMaxY = 0D;
			this.Dispersion.ScrollMaxY2 = 0D;
			this.Dispersion.ScrollMinX = 0D;
			this.Dispersion.ScrollMinY = 0D;
			this.Dispersion.ScrollMinY2 = 0D;
			this.Dispersion.Size = new System.Drawing.Size(680, 370);
			this.Dispersion.TabIndex = 13;
			this.Dispersion.Visible = false;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.lblContingencia);
			this.groupBox5.Controls.Add(this.lblChiCuadrada);
			this.groupBox5.Controls.Add(this.dgvContingencia);
			this.groupBox5.Location = new System.Drawing.Point(1170, 9);
			this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox5.Size = new System.Drawing.Size(537, 363);
			this.groupBox5.TabIndex = 11;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Análisis de atributos categoricos";
			// 
			// lblContingencia
			// 
			this.lblContingencia.AutoSize = true;
			this.lblContingencia.Location = new System.Drawing.Point(5, 306);
			this.lblContingencia.Name = "lblContingencia";
			this.lblContingencia.Size = new System.Drawing.Size(186, 17);
			this.lblContingencia.TabIndex = 13;
			this.lblContingencia.Text = "Coeficiente de contingencia:";
			// 
			// lblChiCuadrada
			// 
			this.lblChiCuadrada.AutoSize = true;
			this.lblChiCuadrada.Location = new System.Drawing.Point(5, 265);
			this.lblChiCuadrada.Name = "lblChiCuadrada";
			this.lblChiCuadrada.Size = new System.Drawing.Size(96, 17);
			this.lblChiCuadrada.TabIndex = 1;
			this.lblChiCuadrada.Text = "Chi cuadrada:";
			// 
			// dgvContingencia
			// 
			this.dgvContingencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvContingencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvContingencia.Location = new System.Drawing.Point(5, 31);
			this.dgvContingencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvContingencia.Name = "dgvContingencia";
			this.dgvContingencia.RowTemplate.Height = 24;
			this.dgvContingencia.Size = new System.Drawing.Size(525, 191);
			this.dgvContingencia.TabIndex = 12;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.lblCoeficienteCorrelacion);
			this.groupBox4.Location = new System.Drawing.Point(856, 9);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox4.Size = new System.Drawing.Size(299, 142);
			this.groupBox4.TabIndex = 10;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Análisis de atributos numericos";
			// 
			// lblCoeficienteCorrelacion
			// 
			this.lblCoeficienteCorrelacion.AutoSize = true;
			this.lblCoeficienteCorrelacion.Location = new System.Drawing.Point(5, 34);
			this.lblCoeficienteCorrelacion.Name = "lblCoeficienteCorrelacion";
			this.lblCoeficienteCorrelacion.Size = new System.Drawing.Size(79, 17);
			this.lblCoeficienteCorrelacion.TabIndex = 0;
			this.lblCoeficienteCorrelacion.Text = "Valor de R:";
			// 
			// btnCorrelacion
			// 
			this.btnCorrelacion.Location = new System.Drawing.Point(475, 91);
			this.btnCorrelacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCorrelacion.Name = "btnCorrelacion";
			this.btnCorrelacion.Size = new System.Drawing.Size(374, 60);
			this.btnCorrelacion.TabIndex = 9;
			this.btnCorrelacion.Text = "Calcular correlación";
			this.btnCorrelacion.UseVisualStyleBackColor = true;
			this.btnCorrelacion.Click += new System.EventHandler(this.BtnCorrelacionClick);
			// 
			// cboBivariable2
			// 
			this.cboBivariable2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBivariable2.FormattingEnabled = true;
			this.cboBivariable2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboBivariable2.Location = new System.Drawing.Point(475, 41);
			this.cboBivariable2.Margin = new System.Windows.Forms.Padding(4);
			this.cboBivariable2.Name = "cboBivariable2";
			this.cboBivariable2.Size = new System.Drawing.Size(374, 24);
			this.cboBivariable2.TabIndex = 8;
			// 
			// cboBivariable1
			// 
			this.cboBivariable1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBivariable1.FormattingEnabled = true;
			this.cboBivariable1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboBivariable1.Location = new System.Drawing.Point(473, 9);
			this.cboBivariable1.Margin = new System.Windows.Forms.Padding(4);
			this.cboBivariable1.Name = "cboBivariable1";
			this.cboBivariable1.Size = new System.Drawing.Size(376, 24);
			this.cboBivariable1.TabIndex = 7;
			// 
			// dgvBivariable
			// 
			this.dgvBivariable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBivariable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBivariable.Location = new System.Drawing.Point(5, 9);
			this.dgvBivariable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvBivariable.Name = "dgvBivariable";
			this.dgvBivariable.RowTemplate.Height = 24;
			this.dgvBivariable.Size = new System.Drawing.Size(461, 677);
			this.dgvBivariable.TabIndex = 6;
			// 
			// tbLimpieza
			// 
			this.tbLimpieza.Controls.Add(this.groupBox9);
			this.tbLimpieza.Controls.Add(this.groupBox8);
			this.tbLimpieza.Controls.Add(this.psbLimpieza);
			this.tbLimpieza.Controls.Add(this.groupBox7);
			this.tbLimpieza.Controls.Add(this.groupBox6);
			this.tbLimpieza.Controls.Add(this.gbTransformacion);
			this.tbLimpieza.Controls.Add(this.gbLimpieza1);
			this.tbLimpieza.Location = new System.Drawing.Point(4, 25);
			this.tbLimpieza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbLimpieza.Name = "tbLimpieza";
			this.tbLimpieza.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbLimpieza.Size = new System.Drawing.Size(1793, 695);
			this.tbLimpieza.TabIndex = 3;
			this.tbLimpieza.Text = "Limpieza de datos";
			this.tbLimpieza.UseVisualStyleBackColor = true;
			// 
			// groupBox9
			// 
			this.groupBox9.Controls.Add(this.btnBuscarReemplazar);
			this.groupBox9.Location = new System.Drawing.Point(939, 360);
			this.groupBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox9.Size = new System.Drawing.Size(396, 169);
			this.groupBox9.TabIndex = 17;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Buscar y reemplazar";
			// 
			// btnBuscarReemplazar
			// 
			this.btnBuscarReemplazar.Location = new System.Drawing.Point(22, 55);
			this.btnBuscarReemplazar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBuscarReemplazar.Name = "btnBuscarReemplazar";
			this.btnBuscarReemplazar.Size = new System.Drawing.Size(359, 68);
			this.btnBuscarReemplazar.TabIndex = 14;
			this.btnBuscarReemplazar.Text = "Buscar y reemplazar";
			this.btnBuscarReemplazar.UseVisualStyleBackColor = true;
			this.btnBuscarReemplazar.Click += new System.EventHandler(this.BtnBuscarReemplazarClick);
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.btnMuestreo);
			this.groupBox8.Controls.Add(this.rdbMuestroSinReemplazo);
			this.groupBox8.Controls.Add(this.rdbMuestroReemplazo);
			this.groupBox8.Location = new System.Drawing.Point(488, 360);
			this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox8.Size = new System.Drawing.Size(396, 169);
			this.groupBox8.TabIndex = 16;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Muestreo de datos";
			// 
			// btnMuestreo
			// 
			this.btnMuestreo.Location = new System.Drawing.Point(230, 42);
			this.btnMuestreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnMuestreo.Name = "btnMuestreo";
			this.btnMuestreo.Size = new System.Drawing.Size(141, 68);
			this.btnMuestreo.TabIndex = 14;
			this.btnMuestreo.Text = "Realizar muestreo";
			this.btnMuestreo.UseVisualStyleBackColor = true;
			this.btnMuestreo.Click += new System.EventHandler(this.BtnMuestreoClick);
			// 
			// rdbMuestroSinReemplazo
			// 
			this.rdbMuestroSinReemplazo.AutoSize = true;
			this.rdbMuestroSinReemplazo.Location = new System.Drawing.Point(13, 79);
			this.rdbMuestroSinReemplazo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdbMuestroSinReemplazo.Name = "rdbMuestroSinReemplazo";
			this.rdbMuestroSinReemplazo.Size = new System.Drawing.Size(172, 21);
			this.rdbMuestroSinReemplazo.TabIndex = 12;
			this.rdbMuestroSinReemplazo.Text = "Muestre sin reemplazo";
			this.rdbMuestroSinReemplazo.UseVisualStyleBackColor = true;
			// 
			// rdbMuestroReemplazo
			// 
			this.rdbMuestroReemplazo.AutoSize = true;
			this.rdbMuestroReemplazo.Checked = true;
			this.rdbMuestroReemplazo.Location = new System.Drawing.Point(13, 42);
			this.rdbMuestroReemplazo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdbMuestroReemplazo.Name = "rdbMuestroReemplazo";
			this.rdbMuestroReemplazo.Size = new System.Drawing.Size(185, 21);
			this.rdbMuestroReemplazo.TabIndex = 11;
			this.rdbMuestroReemplazo.TabStop = true;
			this.rdbMuestroReemplazo.Text = "Muestreo con reemplazo";
			this.rdbMuestroReemplazo.UseVisualStyleBackColor = true;
			// 
			// psbLimpieza
			// 
			this.psbLimpieza.Location = new System.Drawing.Point(6, 621);
			this.psbLimpieza.Name = "psbLimpieza";
			this.psbLimpieza.Size = new System.Drawing.Size(371, 23);
			this.psbLimpieza.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.psbLimpieza.TabIndex = 19;
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.label1);
			this.groupBox7.Controls.Add(this.btnDetectarErrores);
			this.groupBox7.Controls.Add(this.cboErroresTipograficos);
			this.groupBox7.Location = new System.Drawing.Point(1407, 6);
			this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox7.Size = new System.Drawing.Size(371, 336);
			this.groupBox7.TabIndex = 18;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Detección de errores tipográficos";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 154);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 17);
			this.label1.TabIndex = 16;
			// 
			// btnDetectarErrores
			// 
			this.btnDetectarErrores.Enabled = false;
			this.btnDetectarErrores.Location = new System.Drawing.Point(13, 95);
			this.btnDetectarErrores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDetectarErrores.Name = "btnDetectarErrores";
			this.btnDetectarErrores.Size = new System.Drawing.Size(345, 60);
			this.btnDetectarErrores.TabIndex = 16;
			this.btnDetectarErrores.Text = "Detectar errores tipográficos";
			this.btnDetectarErrores.UseVisualStyleBackColor = true;
			this.btnDetectarErrores.Click += new System.EventHandler(this.BtnDetectarErroresClick);
			// 
			// cboErroresTipograficos
			// 
			this.cboErroresTipograficos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboErroresTipograficos.FormattingEnabled = true;
			this.cboErroresTipograficos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboErroresTipograficos.Location = new System.Drawing.Point(13, 37);
			this.cboErroresTipograficos.Margin = new System.Windows.Forms.Padding(4);
			this.cboErroresTipograficos.Name = "cboErroresTipograficos";
			this.cboErroresTipograficos.Size = new System.Drawing.Size(345, 24);
			this.cboErroresTipograficos.TabIndex = 8;
			this.cboErroresTipograficos.SelectedIndexChanged += new System.EventHandler(this.CboErroresTipograficosSelectedIndexChanged);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.btnReemplazarOutliers);
			this.groupBox6.Controls.Add(this.rdbMedianaOutlier);
			this.groupBox6.Controls.Add(this.rdbMediaOutlier);
			this.groupBox6.Controls.Add(this.lblRecomendacionOutliers);
			this.groupBox6.Controls.Add(this.btnAnalisisOutlier);
			this.groupBox6.Controls.Add(this.cboOutliers);
			this.groupBox6.Location = new System.Drawing.Point(488, 6);
			this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox6.Size = new System.Drawing.Size(371, 336);
			this.groupBox6.TabIndex = 16;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Detección de Outliers";
			// 
			// btnReemplazarOutliers
			// 
			this.btnReemplazarOutliers.Enabled = false;
			this.btnReemplazarOutliers.Location = new System.Drawing.Point(217, 254);
			this.btnReemplazarOutliers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnReemplazarOutliers.Name = "btnReemplazarOutliers";
			this.btnReemplazarOutliers.Size = new System.Drawing.Size(141, 47);
			this.btnReemplazarOutliers.TabIndex = 16;
			this.btnReemplazarOutliers.Text = "Reemplazar";
			this.btnReemplazarOutliers.UseVisualStyleBackColor = true;
			this.btnReemplazarOutliers.Click += new System.EventHandler(this.BtnReemplazarOutliersClick);
			// 
			// rdbMedianaOutlier
			// 
			this.rdbMedianaOutlier.AutoSize = true;
			this.rdbMedianaOutlier.Enabled = false;
			this.rdbMedianaOutlier.Location = new System.Drawing.Point(13, 279);
			this.rdbMedianaOutlier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdbMedianaOutlier.Name = "rdbMedianaOutlier";
			this.rdbMedianaOutlier.Size = new System.Drawing.Size(83, 21);
			this.rdbMedianaOutlier.TabIndex = 16;
			this.rdbMedianaOutlier.Text = "Mediana";
			this.rdbMedianaOutlier.UseVisualStyleBackColor = true;
			// 
			// rdbMediaOutlier
			// 
			this.rdbMediaOutlier.AutoSize = true;
			this.rdbMediaOutlier.Enabled = false;
			this.rdbMediaOutlier.Location = new System.Drawing.Point(13, 254);
			this.rdbMediaOutlier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdbMediaOutlier.Name = "rdbMediaOutlier";
			this.rdbMediaOutlier.Size = new System.Drawing.Size(71, 21);
			this.rdbMediaOutlier.TabIndex = 17;
			this.rdbMediaOutlier.TabStop = true;
			this.rdbMediaOutlier.Text = "Media:";
			this.rdbMediaOutlier.UseVisualStyleBackColor = true;
			// 
			// lblRecomendacionOutliers
			// 
			this.lblRecomendacionOutliers.AutoSize = true;
			this.lblRecomendacionOutliers.Location = new System.Drawing.Point(13, 154);
			this.lblRecomendacionOutliers.Name = "lblRecomendacionOutliers";
			this.lblRecomendacionOutliers.Size = new System.Drawing.Size(0, 17);
			this.lblRecomendacionOutliers.TabIndex = 16;
			// 
			// btnAnalisisOutlier
			// 
			this.btnAnalisisOutlier.Location = new System.Drawing.Point(13, 66);
			this.btnAnalisisOutlier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAnalisisOutlier.Name = "btnAnalisisOutlier";
			this.btnAnalisisOutlier.Size = new System.Drawing.Size(345, 60);
			this.btnAnalisisOutlier.TabIndex = 16;
			this.btnAnalisisOutlier.Text = "Análizar atributo";
			this.btnAnalisisOutlier.UseVisualStyleBackColor = true;
			this.btnAnalisisOutlier.Click += new System.EventHandler(this.BtnAnalisisOutlierClick);
			// 
			// cboOutliers
			// 
			this.cboOutliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboOutliers.FormattingEnabled = true;
			this.cboOutliers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboOutliers.Location = new System.Drawing.Point(13, 37);
			this.cboOutliers.Margin = new System.Windows.Forms.Padding(4);
			this.cboOutliers.Name = "cboOutliers";
			this.cboOutliers.Size = new System.Drawing.Size(345, 24);
			this.cboOutliers.TabIndex = 8;
			// 
			// gbTransformacion
			// 
			this.gbTransformacion.Controls.Add(this.btnTransformar);
			this.gbTransformacion.Controls.Add(this.rdbz_scoreabsoluta);
			this.gbTransformacion.Controls.Add(this.rdbz_score);
			this.gbTransformacion.Controls.Add(this.rdbmin_max);
			this.gbTransformacion.Controls.Add(this.cbxtransformacion);
			this.gbTransformacion.Location = new System.Drawing.Point(939, 4);
			this.gbTransformacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gbTransformacion.Name = "gbTransformacion";
			this.gbTransformacion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gbTransformacion.Size = new System.Drawing.Size(396, 336);
			this.gbTransformacion.TabIndex = 15;
			this.gbTransformacion.TabStop = false;
			this.gbTransformacion.Text = "Transformación de Datos por Atributo";
			// 
			// btnTransformar
			// 
			this.btnTransformar.Location = new System.Drawing.Point(217, 82);
			this.btnTransformar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnTransformar.Name = "btnTransformar";
			this.btnTransformar.Size = new System.Drawing.Size(141, 68);
			this.btnTransformar.TabIndex = 15;
			this.btnTransformar.Text = "Transformar";
			this.btnTransformar.UseVisualStyleBackColor = true;
			this.btnTransformar.Click += new System.EventHandler(this.BtntrandormarClick);
			// 
			// rdbz_scoreabsoluta
			// 
			this.rdbz_scoreabsoluta.AutoSize = true;
			this.rdbz_scoreabsoluta.Enabled = false;
			this.rdbz_scoreabsoluta.Location = new System.Drawing.Point(13, 178);
			this.rdbz_scoreabsoluta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdbz_scoreabsoluta.Name = "rdbz_scoreabsoluta";
			this.rdbz_scoreabsoluta.Size = new System.Drawing.Size(180, 21);
			this.rdbz_scoreabsoluta.TabIndex = 14;
			this.rdbz_scoreabsoluta.Text = "Z-Score media absoluta";
			this.rdbz_scoreabsoluta.UseVisualStyleBackColor = true;
			// 
			// rdbz_score
			// 
			this.rdbz_score.AutoSize = true;
			this.rdbz_score.Enabled = false;
			this.rdbz_score.Location = new System.Drawing.Point(13, 130);
			this.rdbz_score.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdbz_score.Name = "rdbz_score";
			this.rdbz_score.Size = new System.Drawing.Size(80, 21);
			this.rdbz_score.TabIndex = 12;
			this.rdbz_score.Text = "Z-Score";
			this.rdbz_score.UseVisualStyleBackColor = true;
			// 
			// rdbmin_max
			// 
			this.rdbmin_max.AutoSize = true;
			this.rdbmin_max.Checked = true;
			this.rdbmin_max.Enabled = false;
			this.rdbmin_max.Location = new System.Drawing.Point(13, 86);
			this.rdbmin_max.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdbmin_max.Name = "rdbmin_max";
			this.rdbmin_max.Size = new System.Drawing.Size(81, 21);
			this.rdbmin_max.TabIndex = 11;
			this.rdbmin_max.TabStop = true;
			this.rdbmin_max.Text = "Min-Max";
			this.rdbmin_max.UseVisualStyleBackColor = true;
			// 
			// cbxtransformacion
			// 
			this.cbxtransformacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxtransformacion.FormattingEnabled = true;
			this.cbxtransformacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cbxtransformacion.Location = new System.Drawing.Point(13, 37);
			this.cbxtransformacion.Margin = new System.Windows.Forms.Padding(4);
			this.cbxtransformacion.Name = "cbxtransformacion";
			this.cbxtransformacion.Size = new System.Drawing.Size(345, 24);
			this.cbxtransformacion.TabIndex = 8;
			this.cbxtransformacion.SelectedIndexChanged += new System.EventHandler(this.CbxtransformacionSelectedIndexChanged);
			// 
			// gbLimpieza1
			// 
			this.gbLimpieza1.Controls.Add(this.rdbModa);
			this.gbLimpieza1.Controls.Add(this.btnLlenar);
			this.gbLimpieza1.Controls.Add(this.lblRecomendacion);
			this.gbLimpieza1.Controls.Add(this.rdbMediana);
			this.gbLimpieza1.Controls.Add(this.rdbMedia);
			this.gbLimpieza1.Controls.Add(this.btnAnalisisLlenado);
			this.gbLimpieza1.Controls.Add(this.cboLlenadoDatos);
			this.gbLimpieza1.Location = new System.Drawing.Point(5, 6);
			this.gbLimpieza1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gbLimpieza1.Name = "gbLimpieza1";
			this.gbLimpieza1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gbLimpieza1.Size = new System.Drawing.Size(396, 336);
			this.gbLimpieza1.TabIndex = 0;
			this.gbLimpieza1.TabStop = false;
			this.gbLimpieza1.Text = "Llenado de valores faltantes";
			// 
			// rdbModa
			// 
			this.rdbModa.AutoSize = true;
			this.rdbModa.Enabled = false;
			this.rdbModa.Location = new System.Drawing.Point(13, 228);
			this.rdbModa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdbModa.Name = "rdbModa";
			this.rdbModa.Size = new System.Drawing.Size(64, 21);
			this.rdbModa.TabIndex = 15;
			this.rdbModa.Text = "Moda";
			this.rdbModa.UseVisualStyleBackColor = true;
			// 
			// btnLlenar
			// 
			this.btnLlenar.Enabled = false;
			this.btnLlenar.Location = new System.Drawing.Point(217, 154);
			this.btnLlenar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnLlenar.Name = "btnLlenar";
			this.btnLlenar.Size = new System.Drawing.Size(141, 68);
			this.btnLlenar.TabIndex = 14;
			this.btnLlenar.Text = "Llenar valores";
			this.btnLlenar.UseVisualStyleBackColor = true;
			this.btnLlenar.Click += new System.EventHandler(this.BtnLlenarClick);
			// 
			// lblRecomendacion
			// 
			this.lblRecomendacion.AutoSize = true;
			this.lblRecomendacion.Location = new System.Drawing.Point(13, 270);
			this.lblRecomendacion.Name = "lblRecomendacion";
			this.lblRecomendacion.Size = new System.Drawing.Size(114, 17);
			this.lblRecomendacion.TabIndex = 13;
			this.lblRecomendacion.Text = "Recomendación:";
			// 
			// rdbMediana
			// 
			this.rdbMediana.AutoSize = true;
			this.rdbMediana.Enabled = false;
			this.rdbMediana.Location = new System.Drawing.Point(13, 191);
			this.rdbMediana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdbMediana.Name = "rdbMediana";
			this.rdbMediana.Size = new System.Drawing.Size(83, 21);
			this.rdbMediana.TabIndex = 12;
			this.rdbMediana.Text = "Mediana";
			this.rdbMediana.UseVisualStyleBackColor = true;
			// 
			// rdbMedia
			// 
			this.rdbMedia.AutoSize = true;
			this.rdbMedia.Checked = true;
			this.rdbMedia.Enabled = false;
			this.rdbMedia.Location = new System.Drawing.Point(13, 154);
			this.rdbMedia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdbMedia.Name = "rdbMedia";
			this.rdbMedia.Size = new System.Drawing.Size(67, 21);
			this.rdbMedia.TabIndex = 11;
			this.rdbMedia.TabStop = true;
			this.rdbMedia.Text = "Media";
			this.rdbMedia.UseVisualStyleBackColor = true;
			// 
			// btnAnalisisLlenado
			// 
			this.btnAnalisisLlenado.Location = new System.Drawing.Point(13, 66);
			this.btnAnalisisLlenado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAnalisisLlenado.Name = "btnAnalisisLlenado";
			this.btnAnalisisLlenado.Size = new System.Drawing.Size(345, 60);
			this.btnAnalisisLlenado.TabIndex = 10;
			this.btnAnalisisLlenado.Text = "Análizar atributo";
			this.btnAnalisisLlenado.UseVisualStyleBackColor = true;
			this.btnAnalisisLlenado.Click += new System.EventHandler(this.BtnAnalisisLlenadoClick);
			// 
			// cboLlenadoDatos
			// 
			this.cboLlenadoDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboLlenadoDatos.FormattingEnabled = true;
			this.cboLlenadoDatos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboLlenadoDatos.Location = new System.Drawing.Point(13, 37);
			this.cboLlenadoDatos.Margin = new System.Windows.Forms.Padding(4);
			this.cboLlenadoDatos.Name = "cboLlenadoDatos";
			this.cboLlenadoDatos.Size = new System.Drawing.Size(345, 24);
			this.cboLlenadoDatos.TabIndex = 8;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1825, 750);
			this.Controls.Add(this.tbPrincipal);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.Text = "ProyectoFinalMD";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tbPrincipal.ResumeLayout(false);
			this.tbDatos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabAnalisisUnivariable.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.BoxPlot)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvFrecuencia)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatoEstadisticos)).EndInit();
			this.AnalisisBivariable.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvContingencia)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBivariable)).EndInit();
			this.tbLimpieza.ResumeLayout(false);
			this.groupBox9.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.gbTransformacion.ResumeLayout(false);
			this.gbTransformacion.PerformLayout();
			this.gbLimpieza1.ResumeLayout(false);
			this.gbLimpieza1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}