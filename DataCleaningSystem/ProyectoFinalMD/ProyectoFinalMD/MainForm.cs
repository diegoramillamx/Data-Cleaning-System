using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web.UI.DataVisualization.Charting;
using System.Text.RegularExpressions;

namespace ProyectoFinalMD
{
	public partial class MainForm : Form
	{
		//Ruta de archivo que se está abriendo.
		private string rutaSistema = string.Empty;
		private string modaLlenar;
		private float mediaReemplazo, medianaReemplazo;
		private float medianaLlenar, mediaLlenar;
		private double limiteInferior, limiteSuperior, LimiteInferiorO, LimiteSuperiorO;
		
		//Lista con los nombres de los atributos
		private List<string> atributos = new List<string>();
		
		//Para saber de que tipo es el archivo;
		private bool isCsv = true;
		
		/* VARIABLES PARA CUANDO EL ARCHIVO ES DATA */
		private string comentarios = string.Empty;
		private string nombreRelacion = string.Empty;
		private string valorFaltante = string.Empty;
		private List<string> tipoDatos = new List<string>();
		private List<string> expresionesRegulares = new List<string>();
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		//Función para abrir ventana emergente "OpenFileDialog"
		//Retorna la ruta donde se encuentra el archivo que queremos abrir.
		private string abrirArchivo() 
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = "C:\\";	
			openFileDialog.Filter = "Archivos separado por comas (*.csv)|*.csv|Archivos DATA (*.data)|*.data";
        	openFileDialog.FilterIndex = 1;
        	openFileDialog.RestoreDirectory = true;

        	//El archivo se abrió correctamente
			if (openFileDialog.ShowDialog() == DialogResult.OK) 
			{
        		return openFileDialog.FileName;
			}
        	else //El archivo no se pudo abrir
        	{
        		MessageBox.Show("El archivo no se pudo abrir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        	}
        	
        	return string.Empty;
		}
		
		//Función para mostrar el archivo CSV en el DataGridView
		//Toma como parámetro la ruta del archivo.
		private void mostrarCsv(string ruta) 
		{
			dgvDatos.Columns.Clear();
			atributos.Clear();
			expresionesRegulares.Clear();
			tipoDatos.Clear();
			comentarios = string.Empty;
			
			cbxeliminaratributo.Items.Clear();
			cboAnalisisAtributo.Items.Clear();
			cbxdatosnumericos.Items.Clear();
			cboBivariable1.Items.Clear();
			cboBivariable2.Items.Clear();
			cboLlenadoDatos.Items.Clear();
			cbxtransformacion.Items.Clear();
			cboOutliers.Items.Clear();
			cboErroresTipograficos.Items.Clear();
			
			string [] lineas = System.IO.File.ReadAllLines(ruta, Encoding.UTF8);
			DataTable dt = new DataTable();
			if (lineas.Length > 0) 
			{
				//La primera línea del archivo son el titulo de las columnas
				string [] tituloColumnas = lineas[0].Split(',');
				foreach (string titulo in tituloColumnas) 
				{
					dt.Columns.Add(new DataColumn(titulo));
					atributos.Add(titulo);
					cbxeliminaratributo.Items.Add(titulo);
					cboAnalisisAtributo.Items.Add(titulo);
					cbxdatosnumericos.Items.Add(titulo);	
					cboBivariable1.Items.Add(titulo);
					cboBivariable2.Items.Add(titulo);
					cboLlenadoDatos.Items.Add(titulo);
					cbxtransformacion.Items.Add(titulo);
					cboOutliers.Items.Add(titulo);
					cboErroresTipograficos.Items.Add(titulo);
				}
				//Esta parte es para meter el contenido en el datagrid
				for (int i  = 1; i < lineas.Length; i++)
				{
					string [] contenidoPorLinea = lineas[i].Split(',');
					DataRow dr = dt.NewRow();
					int indiceColumna = 0;
					foreach (string columna in tituloColumnas) 
					{
						dr[columna] = contenidoPorLinea[indiceColumna++];
					}
					dt.Rows.Add(dr);
				}
			}
			
			if (dt.Rows.Count > 0) 
			{
				dgvDatos.DataSource = dt;
			}
		}
		
		private void mostrarData(string ruta) 
		{
			dgvDatos.Columns.Clear();
			atributos.Clear();
			expresionesRegulares.Clear();
			tipoDatos.Clear();
			comentarios = string.Empty;
			
			cbxeliminaratributo.Items.Clear();
			cboAnalisisAtributo.Items.Clear();
			cbxdatosnumericos.Items.Clear();
			cboBivariable1.Items.Clear();
			cboBivariable2.Items.Clear();
			cboLlenadoDatos.Items.Clear();
			cbxtransformacion.Items.Clear();
			cboOutliers.Items.Clear();
			cboErroresTipograficos.Items.Clear();
			
			string [] lineas = System.IO.File.ReadAllLines(ruta, Encoding.UTF8);
			DataTable dt = new DataTable();
			
			int i = 0;
			if (lineas.Length > 0) 
			{
				for (i = 0; i < lineas.Length; i++)
				{
					if (string.IsNullOrEmpty(lineas[i]))
					{
						continue;
					}
					else if (lineas[i][0] == '%') 
					{
						comentarios += lineas[i] + Environment.NewLine;
					}
					else if (lineas[i][0] == '@')
					{
						string nuevaLinea = lineas[i].Substring(1);
						string [] valorNuevaLinea = nuevaLinea.Split(' ');
						
						if (valorNuevaLinea[0] == "attribute") 
						{
							dt.Columns.Add(new DataColumn(valorNuevaLinea[1]));
							atributos.Add(valorNuevaLinea[1]);
							cbxeliminaratributo.Items.Add(valorNuevaLinea[1]);
							cboAnalisisAtributo.Items.Add(valorNuevaLinea[1]);
							cbxdatosnumericos.Items.Add(valorNuevaLinea[1]);	
							cboBivariable1.Items.Add(valorNuevaLinea[1]);
							cboBivariable2.Items.Add(valorNuevaLinea[1]);
							cboLlenadoDatos.Items.Add(valorNuevaLinea[1]);
							cbxtransformacion.Items.Add(valorNuevaLinea[1]);
							cboOutliers.Items.Add(valorNuevaLinea[1]);
							cboErroresTipograficos.Items.Add(valorNuevaLinea[1]);
							tipoDatos.Add(valorNuevaLinea[2]);
							expresionesRegulares.Add(valorNuevaLinea[3]);
						}
						else if (valorNuevaLinea[0] == "relation")
						{
							nombreRelacion = valorNuevaLinea[1];
						}
						else if (valorNuevaLinea[0] == "missingValue") 
						{
							if (valorNuevaLinea.Length > 1)
								valorFaltante = valorNuevaLinea[1];
						}
						else if (valorNuevaLinea[0] == "data")
						{
							break;
						}
					}
				}
				for (int j = i + 1; j < lineas.Length; j++) 
				{
					string [] contenidoPorLinea = lineas[j].Split(',');
					DataRow dr = dt.NewRow();
					int indiceColumna = 0;
					for (int k = 0; k < dt.Columns.Count; k++)
					{
						dr[k] = contenidoPorLinea[indiceColumna++];
					}
					dt.Rows.Add(dr);
				}
				
				if (dt.Rows.Count > 0) 
				{
					dgvDatos.DataSource = dt;
				}
			}
		}
		
		public void colorearDataGridDatos()
		{
			int filas = dgvDatos.RowCount - 1;
			int columnas = dgvDatos.Columns.Count;
			
			if (expresionesRegulares.Count == 0) return;
			
			for (int i = 0; i < filas; i++)
			{
				pdbDatos.Value = (i * 100) / filas;
				for (int j = 0; j < columnas; j++)
				{
					string valor = dgvDatos.Rows[i].Cells[j].Value.ToString();
					if (valor == string.Empty)
					{
						dgvDatos.Rows[i].Cells[j].Value = valorFaltante;
					}
					
					if (Regex.IsMatch(valor, expresionesRegulares[j])) 
					{
						dgvDatos.Rows[i].Cells[j].Style.BackColor = Color.LightGreen;
					}
					else 
					{
						dgvDatos.Rows[i].Cells[j].Style.BackColor = Color.OrangeRed;
					}
				}
			}
			pdbDatos.Value = 0;
		}
		
		public void guardarCsv(string ruta)
        {
            //Si el dataGrid tiene más datos
            if (dgvDatos.RowCount > 0)
            {
            	string value = string.Empty;
            	
                DataGridViewRow dr = new DataGridViewRow();
                StreamWriter archivoSalida = new StreamWriter(ruta);

                //Esta parte escribe el titulo de las columnas en el archivo
                for (int i = 0; i < dgvDatos.Columns.Count; i++)
                {
                	if (i > 0) archivoSalida.Write(",");
                    archivoSalida.Write(dgvDatos.Columns[i].HeaderText);
                }
                archivoSalida.WriteLine();

                //Escribe el contenido del dataGrid en el archivo
                for (int j = 0; j < dgvDatos.Rows.Count - 1; j++)
                {
                    if (j > 0) archivoSalida.WriteLine();

                    dr = dgvDatos.Rows[j];
                    for (int i = 0; i < dgvDatos.Columns.Count; i++)
                    {
                        if (i > 0) archivoSalida.Write(",");

                        value = dr.Cells[i].Value.ToString();
                        
                        if (value == valorFaltante) value = string.Empty;
                        
                        value = value.Replace(',', ' ');
                        value = value.Replace(Environment.NewLine, " ");
                        archivoSalida.Write(value);
                    }
                }
                archivoSalida.Close();
            }
        }
		
		public void guardarData(string ruta)
        {
            //Si el dataGrid tiene más datos
            if (dgvDatos.RowCount > 0)
            {
            	string value = string.Empty;
                DataGridViewRow dr = new DataGridViewRow();
                StreamWriter archivoSalida = new StreamWriter(ruta);

                archivoSalida.Write(comentarios);
                archivoSalida.WriteLine();
                
                archivoSalida.Write("@relation " + nombreRelacion);
                archivoSalida.WriteLine();
                
                for (int i = 0; i < atributos.Count; i++) 
                {
                	atributos[i] = atributos[i].Replace(' ', '_');
                	archivoSalida.Write("@attribute " + atributos[i] + " " + tipoDatos[i] + " " + expresionesRegulares[i]);
                	archivoSalida.WriteLine();
                }
                
                archivoSalida.Write("@missingValue " + valorFaltante);
                archivoSalida.WriteLine();
                
                archivoSalida.Write("@data");
                archivoSalida.WriteLine();
                
                //Escribe el contenido del dataGrid en el archivo
                for (int j = 0; j < dgvDatos.Rows.Count - 1; j++)
                {
                    if (j > 0) archivoSalida.WriteLine();

                    dr = dgvDatos.Rows[j];
                    for (int i = 0; i < dgvDatos.Columns.Count; i++)
                    {
                        if (i > 0) archivoSalida.Write(",");

                        value = dr.Cells[i].Value.ToString();
                        value = value.Replace(',', ' ');
                        value = value.Replace(Environment.NewLine, " ");
                        archivoSalida.Write(value);
                    }
                    
                }
                archivoSalida.Close();
            }
        }
		
		//Función para sacar los valores faltantes del archivo
		/*
		 * Compara si algún valor es igual a vacio y si es así le suma 1
		 * a la variable valores faltantes
		 */
		private int valoresFaltantes() 
		{
			int valoresFaltante = 0;
			for (int i = 0; i < dgvDatos.Rows.Count - 1; i++) 
			{
				for (int j = 0; j < dgvDatos.Columns.Count; j++)
				{
					string valor = dgvDatos.Rows[i].Cells[j].Value.ToString();
					if (valor == string.Empty || valor == valorFaltante)
	                 {
	                 	valoresFaltante++;
	                  }
				}
			}
			return valoresFaltante;
		}
		
		//Función para mostrar las estadisticas correspondientes del archivo.
		/*
		 * Nombre del archivo 
		 * Número de instancias
		 * Número de atributos
		 * Valores faltes y su proporción.
		 */
		void mostrarEstadisticasDelArchivo() 
		{
			string [] nombre = rutaSistema.Split('\\');
			float total = dgvDatos.Columns.Count * dgvDatos.Rows.Count;
			float faltantes = valoresFaltantes();
			lblNombreArchivo.Text = "Nombre: " + nombre[nombre.Length - 1];
			lblInstancias.Text = "Número de instancias: " + Convert.ToString(dgvDatos.Rows.Count - 1);
			lblAtributos.Text = "Número de atributos: " + Convert.ToString(dgvDatos.Columns.Count);
			lblValores.Text = "Valores faltantes: " + Convert.ToString(faltantes);
			lblProporcion.Text = "Proporción: " + Convert.ToString((faltantes * 100) / total) + "%";
		}
		
		void AbrirToolStripMenuItemClick(object sender, EventArgs e) 
		{
			string ruta = abrirArchivo();
			try
			{
				dgvDatos.Columns.Clear();
				
				if (ruta != string.Empty) {
				rutaSistema = ruta;
				string [] nombre = rutaSistema.Split('\\');
				string tipo = nombre[nombre.Length - 1].Split('.')[1].ToLower();
				
				if (tipo == "csv")
				{
					isCsv = true;
					mostrarCsv(ruta);
					btnModificarExpresion.Enabled = false;
				}
				else 
				{
					mostrarData(ruta);
					colorearDataGridDatos();
					isCsv = false;
					btnModificarExpresion.Enabled = true;
				}
									
				mostrarEstadisticasDelArchivo();
				}
			}
			catch (Exception ex) 
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}
		
		void GuardarToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (rutaSistema != string.Empty) 
			{
				if (isCsv)
				{
					guardarCsv(rutaSistema);	
				}
				else 
				{
					guardarData(rutaSistema);
				}
				MessageBox.Show("Archivo guardado exitosamente.", "Satisfactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("No hay ningún archivo abierto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			
			DialogResult dialogResult = MessageBox.Show("¿Desea guardar los cambios?", "¿Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult == DialogResult.Yes) 
			{
				guardarComoDataSet();
			}
			
			this.Close();
		}
		
		void GuardarComoToolStripMenuItemClick(object sender, EventArgs e)
		{
			guardarComoDataSet();
		}
		
		public void guardarComoDataSet() 
		{
			SaveFileDialog archivoGuardar = new SaveFileDialog();
			archivoGuardar.InitialDirectory = @"C:\";
			archivoGuardar.RestoreDirectory = true;
			archivoGuardar.DefaultExt = "csv";
			archivoGuardar.Filter = "Archivos separado por comas (*.csv)|*.csv|Archivos DATA (*.data)|*.data";
				
			if (archivoGuardar.ShowDialog() == DialogResult.OK) 
			{
				rutaSistema = archivoGuardar.FileName;
				
				string [] array = rutaSistema.Split('\\');
				string tipo = array[array.Length - 1].Split('.')[1].ToLower();
				
				if (tipo == "csv")
				{
					guardarCsv(rutaSistema);	
					mostrarCsv(rutaSistema);
					isCsv = true;
					btnModificarExpresion.Enabled = false;
				}
				else 
				{
					try
					{
						if (isCsv && tipo == "data")
						{
							GuardarData nuevoGuardar = new GuardarData(atributos);
							nuevoGuardar.ShowDialog();
							expresionesRegulares = nuevoGuardar.obtenerExpresiones();
							comentarios = nuevoGuardar.obtenerComentarios();
							tipoDatos = nuevoGuardar.obtenerTipo();
							nombreRelacion = nuevoGuardar.obtenerRelacion();
							valorFaltante = nuevoGuardar.obtenerFaltante();
							isCsv = false;	
						}
						btnModificarExpresion.Enabled = true;
					}
					catch
					{
						MessageBox.Show("Ocurrió un error con el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					
					guardarData(rutaSistema);
					mostrarData(rutaSistema);
					colorearDataGridDatos();
				}
				
				mostrarEstadisticasDelArchivo();
				MessageBox.Show("Archivo guardado exitosamente.", "Satisfactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Ocurrió un error con el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void DgvDatosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			btneliminarinstancia.Text = "Eliminar Instancia " + e.RowIndex.ToString();
		}
		
		void BtneliminarinstanciaClick(object sender, EventArgs e)
		{
			try 
			{
				int identificador = dgvDatos.CurrentRow.Index;
				dgvDatos.Rows.RemoveAt(identificador);
				mostrarEstadisticasDelArchivo();
			}
			catch (Exception)
			{
				MessageBox.Show("Debe de seleccionar una instancia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);	
			}
		}
			
		void BtneliminaratributoClick(object sender, EventArgs e)
		{
			try 
			{
				int cabecera = cbxeliminaratributo.SelectedIndex;
				if (cabecera != -1) {
					dgvDatos.Columns.RemoveAt(cabecera);
					cbxeliminaratributo.Items.RemoveAt(cabecera);
					cboAnalisisAtributo.Items.RemoveAt(cabecera);
					cbxdatosnumericos.Items.RemoveAt(cabecera);
					cboBivariable1.Items.RemoveAt(cabecera);
					cboBivariable2.Items.RemoveAt(cabecera);
					cboLlenadoDatos.Items.RemoveAt(cabecera);
					cbxtransformacion.Items.RemoveAt(cabecera);
					cboOutliers.Items.RemoveAt(cabecera);
					cboErroresTipograficos.Items.RemoveAt(cabecera);
					atributos.RemoveAt(cabecera);
					
					if (!isCsv)
					{
						tipoDatos.RemoveAt(cabecera);
						expresionesRegulares.RemoveAt(cabecera);	
					}
					mostrarEstadisticasDelArchivo();
					}	
			}
			catch (Exception) 
			{
				MessageBox.Show("Debe de seleccionar un atributo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
		}
		
		//Botón para agregar un nuevo atributo sobre el data set.
		void BtnAgregarAtributoClick(object sender, EventArgs e)
		{
			string atributo, valor;
			AgregarAtributo nuevoAtributo = new AgregarAtributo();
			nuevoAtributo.ShowDialog();
			
			atributo = nuevoAtributo.obtenerNombre();
			valor = nuevoAtributo.obtenerValor();
			
			if (string.IsNullOrEmpty(atributo) || string.IsNullOrEmpty(valor)) return;
			
			dgvDatos.Columns.Add(atributo, atributo);
			atributos.Add(atributo);
			cbxeliminaratributo.Items.Add(atributo);
			cboAnalisisAtributo.Items.Add(atributo);
			cbxdatosnumericos.Items.Add(atributo);
			cboBivariable1.Items.Add(atributo);
			cboBivariable2.Items.Add(atributo);
			cboLlenadoDatos.Items.Add(atributo);
			cbxtransformacion.Items.Add(atributo);
			cboOutliers.Items.Add(atributo);
			cboErroresTipograficos.Items.Add(atributo);
			
			if (!isCsv)
			{
				expresionesRegulares.Add("\\w+");
				tipoDatos.Add("categoric");
			}
			
			for (int i = 0; i < dgvDatos.Rows.Count - 1; i++) dgvDatos.Rows[i].Cells[dgvDatos.Columns.Count - 1].Value = valor;
			mostrarEstadisticasDelArchivo();
		}
		
		void BtnModificarClick(object sender, EventArgs e)
		{
			List<string> items = new List<string>();
			int posicion;
			
			for (int i = 0; i < cbxeliminaratributo.Items.Count; i++) {
				items.Add(cbxeliminaratributo.Items[i].ToString());
				}
			try 
			{
				ModificarAtributo modificarAtributo = new ModificarAtributo(items);
				modificarAtributo.ShowDialog();
				items = modificarAtributo.obtenerLista();
				posicion = modificarAtributo.obtenerPosicion();
				dgvDatos.Columns[posicion].HeaderText = items[posicion];
				
				atributos.Clear();
				cbxeliminaratributo.Items.Clear();
				cboAnalisisAtributo.Items.Clear();
				cbxdatosnumericos.Items.Clear();
				cboBivariable1.Items.Clear();
				cboBivariable2.Items.Clear();
				cboLlenadoDatos.Items.Clear();
				cbxtransformacion.Items.Clear();
				cboOutliers.Items.Clear();
				cboErroresTipograficos.Items.Clear();
			}
			catch (Exception)
			{
				MessageBox.Show("Ocurrió un error", "Error", MessageBoxButtons.OK);
				return;
			}
			
			for (int i = 0; i < items.Count; i++) 
			{
				atributos.Add(items[i]);
				cbxeliminaratributo.Items.Add(items[i]);
				cboAnalisisAtributo.Items.Add(items[i]);
				cbxdatosnumericos.Items.Add(items[i]);
				cboBivariable1.Items.Add(items[i]);
				cboBivariable2.Items.Add(items[i]);
				cboLlenadoDatos.Items.Add(items[i]);
				cbxtransformacion.Items.Add(items[i]);
				cboOutliers.Items.Add(items[i]);
				cboErroresTipograficos.Items.Add(items[i]);
			}
		}
		
		void CboAnalisisAtributoSelectedIndexChanged(object sender, EventArgs e)
		{
			lblTipoDato.Text = "";
			
			int index = cboAnalisisAtributo.SelectedIndex;
			int faltantes = 0;
			for (int i = 0; i < dgvDatos.Rows.Count - 1; i++) 
			{
				string valor = dgvDatos.Rows[i].Cells[index].Value.ToString();
				if (string.IsNullOrEmpty(valor) || valorFaltante == valor)
				{
					faltantes++;
				}
			}
			
			lblFaltantesAtributo.Text = "Valores faltantes: " + Convert.ToString(faltantes);
			lblProporcionAtributos.Text = "Proporción: " + Convert.ToString((faltantes * 100) / (dgvDatos.Rows.Count - 1)) + "%";
			
			if (!isCsv)
			{
				lblTipoDato.Text = "Tipo de dato: " + tipoDatos[index];
			}
		}
		
		/*
		 * CÓDIGO PARA EL ANÁLISIS UNIVARIABLE TODO
		 */
		
		//Llena el dataGridView de análisis univariable				
		public void llenarDataGridUnivariable() 
		{
			dgvDatoEstadisticos.Columns.Clear();
			string cabecera = cbxdatosnumericos.SelectedItem.ToString();
			dgvDatoEstadisticos.Columns.Add(cabecera, cabecera);
			dgvDatoEstadisticos.Rows.Add(dgvDatos.Rows.Count - 1); 

			for (int i = 0; i < dgvDatos.Rows.Count - 1; i++)
			{
				dgvDatoEstadisticos.Rows[i].Cells[0].Value = dgvDatos.Rows[i].Cells[cbxdatosnumericos.SelectedIndex].Value;
			}
		}
		
		public void GraficaCategoricos()
		{
			string cabecera = cbxdatosnumericos.SelectedItem.ToString();
			BoxPlot.Series.Clear();
			BoxPlot.Series.Add(cabecera);
			BoxPlot.Series[cabecera].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
			List<string> items = new List<string>();
			for (int i = 0; i < dgvFrecuencia.Columns.Count; i++) 
			{
				BoxPlot.Series[cabecera].Points.AddXY(dgvFrecuencia.Columns[i].HeaderText,dgvFrecuencia.Rows[0].Cells[i].Value.ToString());
			}			
		}
		
		public void BoxPlotNumericos()
		{
			string cabecera = cbxdatosnumericos.SelectedItem.ToString();
			BoxPlot.Series.Add(cabecera);
			BoxPlot.Series[cabecera].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
			
			//Respalda y Ordena datos de Grid DatosEstadiscos
			List<float> items = new List<float>();
			for (int i = 0; i < dgvDatoEstadisticos.Rows.Count - 1; i++) 
			{
				string valor = dgvDatoEstadisticos.Rows[i].Cells[0].Value.ToString();
				if (!string.IsNullOrEmpty(valor) && valor != valorFaltante)
					items.Add(Convert.ToSingle(valor));
			}
			
			items.Sort();			
			double Q1 = 0.25*(items.Count);
			double Q3 = 0.75*(items.Count);
			//Obtiene Quartil1 y Quartil3 
			double itemQ1=0, itemQ3=0, rangointercuartil=0, Ls=0, Li=0;
			for (int i = 0; i < Q1; i++)
			{
				itemQ1 = items[i];
				for(int j=0; j < Q3; j++ )
				{
					itemQ3 = items[j];
				}	
			}
			double primero = items.First();
			double ultimo = items.Last();
			rangointercuartil = itemQ3-itemQ1;
			
			Ls = itemQ3+(rangointercuartil*1.5);
			Li = itemQ1-(rangointercuartil*1.5);
			
			double media = Convert.ToDouble(TendenciaCentral.mediaNumericos(dgvDatos, cbxdatosnumericos.SelectedIndex, valorFaltante));
			double desviacion = Convert.ToDouble(TendenciaCentral.desviacionEstandar(dgvDatos, cbxdatosnumericos.SelectedIndex, valorFaltante));
			
			BoxPlot.Series[cabecera].Points.AddY(0,primero,itemQ1,itemQ3,ultimo,media);
			
		}
		
		//Cuando el comboBox de análisis univariable cambia de valor se ejecuta este evento.
		void CbxdatosnumericosSelectedIndexChanged(object sender, EventArgs e)
		{
			llenarDataGridUnivariable();
			dgvFrecuencia.Columns.Clear();
			dgvFrecuencia.Rows.Clear();
			BoxPlot.Series.Clear();
			
			try 
			{	
				lblmedia.Text = "Media: " + Convert.ToString(TendenciaCentral.mediaNumericos(dgvDatos, cbxdatosnumericos.SelectedIndex, valorFaltante));
				lblmediana.Text = "Mediana: " + Convert.ToString(TendenciaCentral.medianaNumericos(dgvDatos, cbxdatosnumericos.SelectedIndex, valorFaltante));
				lblmoda.Text = "Moda: " + Convert.ToString(TendenciaCentral.modaNumericos(dgvDatos, cbxdatosnumericos.SelectedIndex, valorFaltante));
				lblDesviacion.Text = "Desviación estándar: " + Convert.ToString(TendenciaCentral.desviacionEstandar(dgvDatos, cbxdatosnumericos.SelectedIndex, valorFaltante));
				BoxPlotNumericos();
			}
			catch
			{
				lblmedia.Text = "";
				lblDesviacion.Text = "";
				lblmoda.Text = "Moda: " + TendenciaCentral.modaCategoricos(dgvDatos, dgvFrecuencia, cbxdatosnumericos.SelectedIndex);
				lblmediana.Text = "Mediana: " + TendenciaCentral.medianaCategoricos(dgvDatos, cbxdatosnumericos.SelectedIndex);
				GraficaCategoricos();
			}
		}
		
		/* AQUI ES EL FINAL DEL CÓDIGO DE ANÁLISIS UNIVARIABLE */
		
		
		/*
		 * De aquí en adelante es el código para ANÁLISIS BIVARIABLE TODO
		 */
		public void llenarDataGridBivariable()
		{
			dgvBivariable.Rows.Clear();
			dgvBivariable.Columns.Clear();
			
			string cabecera = cboBivariable1.SelectedItem.ToString();
			dgvBivariable.Columns.Add(cabecera, cabecera);
			dgvBivariable.Rows.Add(dgvDatos.Rows.Count - 1);
			
			
			for (int i = 0; i < dgvDatos.RowCount; i++)
			{
				dgvBivariable.Rows[i].Cells[0].Value = dgvDatos.Rows[i].Cells[cboBivariable1.SelectedIndex].Value;
			}
			cabecera = cboBivariable2.SelectedItem.ToString();
			dgvBivariable.Columns.Add(cabecera, cabecera);
			
			for (int i = 0; i < dgvDatos.RowCount; i++)
			{
				dgvBivariable.Rows[i].Cells[1].Value = dgvDatos.Rows[i].Cells[cboBivariable2.SelectedIndex].Value;
			}
		}
		
		void BtnCorrelacionClick(object sender, EventArgs e)
		{
			Dispersion.Visible = false;
			lblContingencia.Text = "";
			lblCoeficienteCorrelacion.Text = "";
			lblChiCuadrada.Text = "";
			Dispersion.GraphPane.CurveList.Clear();
			Dispersion.Refresh();
			dgvContingencia.Columns.Clear();
			dgvContingencia.Rows.Clear();
			int indice1 = cboBivariable1.SelectedIndex;
			int indice2 = cboBivariable2.SelectedIndex;
			
			if (indice1 == indice2)
			{
				MessageBox.Show("Los atributos seleccionados deben de ser diferentes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else 
			{
				bool esNumerico1 = true;
				bool esNumerico2 = true;
				string dato;
				float valor;
				try 
				{
					for (int i = 0; i < dgvDatos.Rows.Count - 1; i++) 
					{
						dato = dgvDatos.Rows[0].Cells[indice1].Value.ToString();
						if (!string.IsNullOrEmpty(dato) && dato != valorFaltante) 
						{
							valor = Convert.ToSingle(dato);
						}
					}
				}
				catch { esNumerico1 = false; }
				
				try 
				{
					for (int i = 0; i < dgvDatos.Rows.Count - 1; i++) 
					{
						dato = dgvDatos.Rows[0].Cells[indice2].Value.ToString();
						if (!string.IsNullOrEmpty(dato) && dato != valorFaltante) 
						{
							valor = Convert.ToSingle(dato);
						}
					}
				}
				catch { esNumerico2 = false; }
				
				if (esNumerico1 && esNumerico2) {
					llenarDataGridBivariable();
					lblCoeficienteCorrelacion.Text = "Valor de R: " + 
						Convert.ToString(AnalisisCorrelacion.calcularCoeficientePearson(dgvDatos, dgvBivariable, indice1, indice2, valorFaltante));
					GraficaDispersion();
					}
				else if (!esNumerico1 && !esNumerico2) {
					llenarDataGridBivariable();
					string var1 = cboBivariable1.SelectedText.ToString();
					string var2 = cboBivariable2.SelectedText.ToString();
					KeyValuePair<float, float> value = AnalisisCorrelacion.CoeficienteContingencia(dgvContingencia, dgvBivariable, var1, var2);
					lblChiCuadrada.Text = "Chi cuadrada: " + Convert.ToString(value.Value);
					lblContingencia.Text = "Coeficiente de contingencia: " + Convert.ToString(value.Key);
					}
				else {
					MessageBox.Show("No se pueden realizar el análisis con atributos combinados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
		}
		
		public void GraficaDispersion()
		{
			Dispersion.GraphPane.Title.Text = "Grafica de Dispersión";
			Dispersion.GraphPane.XAxis.Title.Text = cboBivariable1.SelectedItem.ToString();
			Dispersion.GraphPane.YAxis.Title.Text = cboBivariable2.SelectedItem.ToString();

			List<double> itemsx = new List<double>(); 
			List<double> itemsy = new List<double>();
			for (int i = 0; i < dgvDatos.Rows.Count - 1; i++)
			{
				string valueX = dgvDatos.Rows[i].Cells[cboBivariable1.SelectedIndex].Value.ToString();
				if (!string.IsNullOrEmpty(valueX) && valueX != valorFaltante)
					itemsx.Add(Convert.ToSingle(dgvDatos.Rows[i].Cells[cboBivariable1.SelectedIndex].Value.ToString()));
				else
					itemsx.Add(0);
				
				string valueY = dgvDatos.Rows[i].Cells[cboBivariable2.SelectedIndex].Value.ToString();
				if (!string.IsNullOrEmpty(valueY) && valueY != valorFaltante)
					itemsy.Add(Convert.ToSingle(dgvDatos.Rows[i].Cells[cboBivariable2.SelectedIndex].Value.ToString()));
				else
					itemsy.Add(0);
			}
			Dispersion.GraphPane.AddCurve(" ",itemsx.ToArray(),itemsy.ToArray(),Color.Blue).Line.IsVisible =false;
			Dispersion.RestoreScale(Dispersion.GraphPane);
			Dispersion.Refresh();
			Dispersion.Visible = true;
		}
		
		/*
		 * DE AQUÍ PARA ABAJO ES LA CUARTA PARTE, LA DE PREPARACIÓN DE LOS DATOS TODO
		 */
		void BtnAnalisisLlenadoClick(object sender, EventArgs e)
		{
			if (cboLlenadoDatos.SelectedIndex == -1) return;
			
			try
			{
				mediaLlenar = TendenciaCentral.mediaNumericos(dgvDatos, cboLlenadoDatos.SelectedIndex, valorFaltante);
				medianaLlenar = TendenciaCentral.medianaNumericos(dgvDatos, cboLlenadoDatos.SelectedIndex, valorFaltante);
				rdbMedia.Enabled = true;
				rdbMediana.Enabled = true;
				rdbMedia.Text = "Media: " + mediaLlenar.ToString();
				rdbMediana.Text = "Mediana: " + medianaLlenar.ToString();
				lblRecomendacion.Text = "Recomendación: Ir al apartado de análisis univariable\npara observar el comportamiento del atributo.";
			}
			catch
			{
				modaLlenar = TendenciaCentral.modaCategoricos(dgvDatos, dgvFrecuencia, cboLlenadoDatos.SelectedIndex);
				dgvFrecuencia.Columns.Clear();
				dgvFrecuencia.Rows.Clear();
				rdbModa.Enabled = true;
				rdbModa.Checked = true;
				rdbModa.Text = "Moda: " + modaLlenar;
				lblRecomendacion.Text = "Recomendación: Al ser un atributo categorico\nsólo se puede utilizar la moda.";
			}
			
			btnLlenar.Enabled = true;
		}
		
		void BtnLlenarClick(object sender, EventArgs e)
		{
			string valorLlenar = string.Empty;
			int index = cboLlenadoDatos.SelectedIndex;
			if (rdbMedia.Checked) 
			{
				valorLlenar = mediaLlenar.ToString();
			}
			else if (rdbMediana.Checked) 
			{
				valorLlenar = medianaLlenar.ToString();
			}
			else if (rdbModa.Checked)
			{
				valorLlenar = modaLlenar;
			}
			
			int n = dgvDatos.RowCount - 1;
			for (int i = 0; i < n; i++) 
			{
				string value = dgvDatos.Rows[i].Cells[index].Value.ToString();
				if (string.IsNullOrEmpty(value) || value == valorFaltante)
				{
					dgvDatos.Rows[i].Cells[index].Value = valorLlenar;
				}
				psbLimpieza.Value = (i * 100) / n;
			}
			
			psbLimpieza.Value = 0;
			rdbMedia.Enabled = false;
			rdbModa.Enabled = false;
			rdbMediana.Enabled = false;
			btnLlenar.Enabled = false;
			rdbMediana.Text = "Mediana";
			rdbMedia.Text = "Media";
			rdbModa.Text = "Moda";
			mostrarEstadisticasDelArchivo();
		}
		
		void BtntrandormarClick(object sender, EventArgs e)
		{
			try
			{
				if (rdbmin_max.Checked) 
				{
					MaximoMinimo nuevoFormulario = new MaximoMinimo();
					nuevoFormulario.ShowDialog();
					Normalizaciones.min_max(dgvDatos, cbxtransformacion.SelectedIndex, nuevoFormulario.obtenerMinimo(), nuevoFormulario.obtenerMaximo()
					                        , nuevoFormulario.obtenerMinimoNuevo(), nuevoFormulario.obtenerMaximoNuevo());
				}
				else if (rdbz_score.Checked) 
				{
					Normalizaciones.zScore(dgvDatos, cbxtransformacion.SelectedIndex, valorFaltante);
				}
				else if (rdbz_scoreabsoluta.Checked) 
				{
					Normalizaciones.zScoreAbsoluta(dgvDatos, cbxtransformacion.SelectedIndex, valorFaltante);
				}
				MessageBox.Show("Se ha realizado la normalización con éxito.", "Satisfactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch
			{
				MessageBox.Show("El atributo no es numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			rdbmin_max.Enabled = false;
			rdbz_score.Enabled = false;
			rdbz_scoreabsoluta.Enabled = false;
			btnTransformar.Enabled = false;
		}
		
		void CbxtransformacionSelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				btnTransformar.Enabled = true;
				rdbmin_max.Enabled = true;
				rdbz_score.Enabled = true;
				rdbz_scoreabsoluta.Enabled = true;
			}
			catch
			{
				rdbmin_max.Enabled = false;
				rdbz_score.Enabled = false;
				rdbz_scoreabsoluta.Enabled = false;
				MessageBox.Show("DEbes seleccionar un atributo numerico");
			}
		}
		
		void BtnAnalisisOutlierClick(object sender, EventArgs e)
		{
			if (cboOutliers.SelectedIndex == -1) return;
			
			int contadorOutlier = 0;
			int contadorPosibleOutlier = 0;
			int n = dgvDatos.Rows.Count - 1;
			List<float> items = new List<float>();
			
			try
			{
				for (int i = 0; i < n; i++) 
				{
					string valor = dgvDatos.Rows[i].Cells[cboOutliers.SelectedIndex].Value.ToString();
					if (!string.IsNullOrEmpty(valor) && valor != valorFaltante)
						items.Add(Convert.ToSingle(valor));
				}
				items.Sort();
			}
			catch
			{
				MessageBox.Show("El tipo de dato no es numerico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			int Q1 = Convert.ToInt32(0.25 * items.Count);
			int Q3 = Convert.ToInt32(0.75 * items.Count);
			
			//Obtiene Quartil1 y Quartil3 
			double itemQ1=0, itemQ3 = 0, rangointercuartil=0, Ls=0, Li=0;
			double limiteOutlierSuperior, limiteOutlierInfierior;
			
			itemQ1 = items[Q1];
			itemQ3 = items[Q3];
			
			double primero = items.First();
			double ultimo = items.Last();
			
			rangointercuartil = itemQ3 - itemQ1;
			
			Ls = itemQ3 + (rangointercuartil * 1.5);
			Li = itemQ1 - (rangointercuartil * 1.5);
			
			limiteOutlierSuperior = itemQ3 + (rangointercuartil * 3);
			limiteOutlierInfierior = itemQ1 - (rangointercuartil * 3);
			
			limiteInferior = Li;
			limiteSuperior = Ls;
			LimiteInferiorO = limiteOutlierInfierior;
			LimiteSuperiorO = limiteOutlierSuperior;
			
			if ((limiteSuperior - limiteInferior) != 0) 
			{
				float promedio = 0;
				for (int i = 0; i < items.Count; i++)
				{
					if (items[i] >= limiteOutlierSuperior || items[i] <= limiteOutlierInfierior) contadorOutlier++;
					else if (items[i] > Ls || items[i] < Li) contadorPosibleOutlier++;
					else promedio += items[i];
				}
				promedio = promedio / (items.Count - contadorOutlier - contadorPosibleOutlier);
				
				mediaReemplazo = promedio;
				medianaReemplazo = TendenciaCentral.medianaNumericos(dgvDatos, cboOutliers.SelectedIndex, valorFaltante);
				rdbMediaOutlier.Text = "Media: " + Convert.ToString(mediaReemplazo);
				rdbMedianaOutlier.Text = "Mediana: " + Convert.ToString(medianaReemplazo);
				rdbMediaOutlier.Enabled = true;
				rdbMedianaOutlier.Enabled = true;
				btnReemplazarOutliers.Enabled = true;
				btnAnalisisOutlier.Enabled = false;
				cboOutliers.Enabled = false;
			}
			
			lblRecomendacionOutliers.Text = "El atributo " + cboOutliers.SelectedItem.ToString() + " tiene: " + Environment.NewLine;
			lblRecomendacionOutliers.Text += "\tUn total de: " + Convert.ToString(contadorOutlier) + " outliers" + Environment.NewLine;
			lblRecomendacionOutliers.Text += "\tUn total de: " + Convert.ToString(contadorPosibleOutlier) + " posibles outliers.";
		}
		
		void BtnReemplazarOutliersClick(object sender, EventArgs e)
		{			
			string valor;
			
			if (rdbMediaOutlier.Checked)
			{
				valor = Convert.ToString(mediaReemplazo);
			}
			else if  (rdbMedianaOutlier.Checked) 
			{
				valor = Convert.ToString(medianaReemplazo);
			}
			else 
			{
				MessageBox.Show("Debe de elegir una medida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			for (int i = 0; i < dgvDatos.Rows.Count - 1; i++) 
			{
				string item = dgvDatos.Rows[i].Cells[cboOutliers.SelectedIndex].Value.ToString();
				
				if (!string.IsNullOrEmpty(item) && item != valorFaltante)
				{
					float itemFloat = Convert.ToSingle(item);
					if (itemFloat >= LimiteSuperiorO || itemFloat <= LimiteInferiorO || itemFloat > limiteSuperior || itemFloat < limiteInferior) 
					{
						dgvDatos.Rows[i].Cells[cboOutliers.SelectedIndex].Value = valor;
					}
				}
			}
			
			btnReemplazarOutliers.Enabled = false;
			rdbMediaOutlier.Enabled = false;
			rdbMedianaOutlier.Enabled = false;
			rdbMediaOutlier.Text = "Media: ";
			rdbMedianaOutlier.Text = "Mediana: ";
			lblRecomendacionOutliers.Text = "";
			cboOutliers.Enabled = true;
			btnAnalisisOutlier.Enabled = true;
		}
		
		void CboErroresTipograficosSelectedIndexChanged(object sender, EventArgs e) {
			
			if (cboErroresTipograficos.SelectedIndex == -1) return;
			
			bool isNumeric = true;
			for (int i = 0; i < dgvDatos.Rows.Count - 1; i++) 
			{
				try 
				{
					string value = dgvDatos.Rows[i].Cells[cboErroresTipograficos.SelectedIndex].Value.ToString();
					if (!string.IsNullOrEmpty(value) && value != valorFaltante) 
					{
						Convert.ToSingle(value);
						break;
					}
				}
				catch 
				{
					isNumeric = false;
					break;
				}
			}
			
			if (isNumeric) {
				MessageBox.Show("El atributo seleccionado no es categorico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				cboErroresTipograficos.SelectedIndex = -1;
				return;
				}
			else {
				btnDetectarErrores.Enabled = true;
				}
			}
		
		void BtnDetectarErroresClick(object sender, EventArgs e) 
		{
			int index = cboErroresTipograficos.SelectedIndex;
			List<string> dominio = new List<string>();
			List<int> distancias = new List<int>();
			
			if (isCsv)
			{
				ErroresGramatica nuevoErrores = new ErroresGramatica();
				nuevoErrores.ShowDialog();
				dominio = nuevoErrores.obtenerLista();
			}
			else if (tipoDatos[index] != "nominal")
			{	
				ErroresGramatica nuevoErrores = new ErroresGramatica();
				nuevoErrores.ShowDialog();
				dominio = nuevoErrores.obtenerLista();		
			}
			else 
			{
				string expresion = expresionesRegulares[index];
				expresion = expresion.Substring(1, expresion.Length - 2);
				dominio = expresion.Split('|').ToList();
			}
			
			for (int i = 0; i < dgvDatos.Rows.Count - 1; i++) 
			{
				
				string valor = dgvDatos.Rows[i].Cells[index].Value.ToString().ToUpper();
				
				if (!string.IsNullOrEmpty(valor) && valor != valorFaltante)
				{
					for (int j = 0; j < dominio.Count; j++)
					{
						int distancia = LevenshteinDistance.ObtenerDistancia(valor, dominio[j].ToUpper());
						distancias.Add(distancia);
					}
					
					
					if (distancias.IndexOf(0) == -1) 
					{
						int indiceMenor = 0;
						int menor = distancias[indiceMenor];
						
						for (int j = 1; j < distancias.Count; j++) 
						{
							if (distancias[j] < menor) 
							{
								indiceMenor = j;
								menor = distancias[indiceMenor];
							}
						}
						
						dgvDatos.Rows[i].Cells[index].Value = dominio[indiceMenor];
					}
					distancias.Clear();
				}
			}
			
			if (!isCsv) 
			{
				colorearDataGridDatos();
			}
			
			MessageBox.Show("Se han detectado y cambiado los valores que eran incorrectos.", "Satisfactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
			btnDetectarErrores.Enabled = false;
		}
		
		
		/*
		 * De aquí en adelante es código para muestreo de datos.
		 */
		void BtnMuestreoClick(object sender, EventArgs e)
		{
			MuestreoDatos formularioMuestreo = new MuestreoDatos(dgvDatos.RowCount - 1);
			formularioMuestreo.ShowDialog();
			int instancias = formularioMuestreo.obtenerInstancias();
			List<int> posiciones = new List<int>();
			
			if (instancias == 0) return;
			
			if (rdbMuestroReemplazo.Checked) 
			{
				posiciones = muestreoConReemplazo(instancias);
			}
			else if (rdbMuestroSinReemplazo.Checked) 
			{
				posiciones = muestreoSinReemplazo(instancias);
			}
			
			SaveFileDialog archivoGuardar = new SaveFileDialog();
			archivoGuardar.InitialDirectory = @"C:\";
			archivoGuardar.RestoreDirectory = true;
			archivoGuardar.DefaultExt = "csv";
			archivoGuardar.Filter = "Archivos separado por comas (*.csv)|*.csv|Archivos DATA (*.data)|*.data";
				
			if (archivoGuardar.ShowDialog() == DialogResult.OK) 
			{
				string rutaMuestreo = archivoGuardar.FileName;
				string [] array = rutaMuestreo.Split('\\');
				string extension = array[array.Length - 1].Split('.')[1].ToLower();
				
				if (extension == "csv")
				{
					guardarMuestreoCsv(rutaMuestreo, posiciones);					
				}
				else 
				{
					GuardarData nuevoGuardar = new GuardarData(atributos);
					nuevoGuardar.ShowDialog();
					List<string> expresiones = nuevoGuardar.obtenerExpresiones();
					string comentario = nuevoGuardar.obtenerComentarios();
					List<string> tipo = nuevoGuardar.obtenerTipo();
					string nombre = nuevoGuardar.obtenerRelacion();
					string faltante = nuevoGuardar.obtenerFaltante();
					guardarMuestreoData(rutaMuestreo, posiciones, tipo, expresiones, comentario, nombre, faltante);
				}
				MessageBox.Show("Se realizó el muestreo con exito.", "Satisfactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Ocurrió un error con el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		List<int> muestreoConReemplazo(int instancias)
		{
			List<int> posiciones = new List<int>();
			Random numeroRandom = new Random();
			
			for (int i = 0; i < instancias; i++) 
			{
				int posicion = numeroRandom.Next(0, dgvDatos.RowCount - 1);
				posiciones.Add(posicion);
			}
			return posiciones;
		}
		
		List<int> muestreoSinReemplazo(int instancias) 
		{
			List<int> posiciones = new List<int>();
			Random numeroRandom = new Random();
			for (int i = 0; i < instancias; i++) 
			{
				int posicion = numeroRandom.Next(0, dgvDatos.RowCount - 1);
				while (posiciones.IndexOf(posicion) != -1) {
					posicion = numeroRandom.Next(0, dgvDatos.RowCount - 1);
					}
				posiciones.Add(posicion);
			}
			return posiciones;
		}
		
		public void guardarMuestreoCsv(string ruta, List<int> posiciones)
        {
            //Si el dataGrid tiene más datos
            if (dgvDatos.RowCount > 0)
            {
            	string value = string.Empty;
            	
                DataGridViewRow dr = new DataGridViewRow();
                StreamWriter archivoSalida = new StreamWriter(ruta);

                //Esta parte escribe el titulo de las columnas en el archivo
                for (int i = 0; i < dgvDatos.Columns.Count; i++)
                {
                	if (i > 0) archivoSalida.Write(",");
                    archivoSalida.Write(dgvDatos.Columns[i].HeaderText);
                }
                archivoSalida.WriteLine();

                //Escribe el contenido del dataGrid en el archivo
                int j = 0;
                foreach (int posicion in posiciones) 
                {
                	dr = dgvDatos.Rows[posicion];
                	
                	if (j > 0) archivoSalida.WriteLine();
                	
					for (int i = 0; i < dgvDatos.Columns.Count; i++)
                    {
                        if (i > 0) archivoSalida.Write(",");

                        value = dr.Cells[i].Value.ToString();
                        value = value.Replace(',', ' ');
                        value = value.Replace(Environment.NewLine, " ");
                        archivoSalida.Write(value);
                    }
					j++;
                }
                archivoSalida.Close();
            }
        }
		
		public void guardarMuestreoData(string ruta, List<int> posiciones, List<string> tipo, List<string> expresiones, string comentario, string nombre, string faltante)
        {
            //Si el dataGrid tiene más datos
            if (dgvDatos.RowCount > 0)
            {
            	string value = string.Empty;
                DataGridViewRow dr = new DataGridViewRow();
                StreamWriter archivoSalida = new StreamWriter(ruta);

                archivoSalida.Write(comentario);
                archivoSalida.WriteLine();
                
                archivoSalida.Write("@relation " + nombre);
                archivoSalida.WriteLine();
                
                for (int i = 0; i < atributos.Count; i++) 
                {
                	atributos[i] = atributos[i].Replace(' ', '_');
                	archivoSalida.Write("@attribute " + atributos[i] + " " + tipo[i] + " " + expresiones[i]);
                	archivoSalida.WriteLine();
                }
                
                archivoSalida.Write("@missingValue " + faltante);
                archivoSalida.WriteLine();
                
                archivoSalida.Write("@data");
                archivoSalida.WriteLine();
                
                //Escribe el contenido del dataGrid en el archivo
                for (int j = 0; j < posiciones.Count; j++)
                {
                    if (j > 0) archivoSalida.WriteLine();

                    dr = dgvDatos.Rows[posiciones[j]];
                    for (int i = 0; i < dgvDatos.Columns.Count; i++)
                    {
                        if (i > 0) archivoSalida.Write(",");

                        value = dr.Cells[i].Value.ToString();
                        value = value.Replace(',', ' ');
                        value = value.Replace(Environment.NewLine, " ");
                        archivoSalida.Write(value);
                    }
                }
                archivoSalida.Close();
            }
        }
		
		void DgvDatosDefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
		{
			
			
			if (!isCsv) 
			{
				colorearDataGridDatos();
			}
			
			mostrarEstadisticasDelArchivo();
		}
		
		void DgvDatosCellLeave(object sender, DataGridViewCellEventArgs e)
		{
			
			if (!isCsv) 
			{
				colorearDataGridDatos();
			}
			
			mostrarEstadisticasDelArchivo();
		}
		
		void BtnBuscarReemplazarClick(object sender, EventArgs e)
		{
			try
			{
				BuscarReemplazar buscar = new BuscarReemplazar(atributos);
				buscar.ShowDialog();
				string valorViejo = buscar.obtenerValorViejo();
				string valorNuevo = buscar.obtenerValorNuevo();
				int index = buscar.obtenerIndex();
				
				if (valorViejo == string.Empty || valorViejo == valorFaltante)
				{
					valorFaltante = valorNuevo;
				}
				
				for (int i = 0; i < dgvDatos.RowCount - 1; i++)
				{
					string valor = dgvDatos.Rows[i].Cells[index].Value.ToString();
					
					if (valor == valorViejo)
					{
						dgvDatos.Rows[i].Cells[index].Value = valorNuevo;
					}
				}
				MessageBox.Show("Se han reemplazado los valores correctamente.", "Satisfactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch
			{
				MessageBox.Show("Ha ocurrido un error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void BtnModificarExpresionClick(object sender, EventArgs e)
		{
			ModificarExpresionRegular modificarExpresion = new ModificarExpresionRegular(atributos, expresionesRegulares);
			modificarExpresion.ShowDialog();
		}
	}
}