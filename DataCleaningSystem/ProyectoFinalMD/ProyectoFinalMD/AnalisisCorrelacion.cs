using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFinalMD
{
	/// <summary>
	/// Description of AnalisisCorrelacion.
	/// </summary>
	public static class AnalisisCorrelacion
	{
				
		//Función para calcular el coeficiente de contingencia.
		/*
		 * Se crea la matriz de frecuencias entre los atributos selecionados
		 * Se hace el calculo de Chi cuadrada y del coeficiente de contingencia
		 */
		public static KeyValuePair<float, float> CoeficienteContingencia(DataGridView dgvContingencia, DataGridView dgvBivariable, string cabecera1, string cabecera2)
		{
			List<string> firstSet = new List<string>();
			List<string> secondSet = new List<string>();
			
			dgvContingencia.Columns.Add("correlacion", cabecera1 + Environment.NewLine  + cabecera2);
			for (int i = 0; i < dgvBivariable.Rows.Count - 1; i++)
			{
				string value1 = dgvBivariable.Rows[i].Cells[0].Value.ToString();
				string value2 = dgvBivariable.Rows[i].Cells[1].Value.ToString();
				if (!firstSet.Contains(value1))
				{
					dgvContingencia.Columns.Add(value1, value1);
					firstSet.Add(value1);
				}			
				if (!secondSet.Contains(value2))
				{
					dgvContingencia.Rows.Add(1);
					dgvContingencia.Rows[secondSet.Count].Cells[0].Value = value2;
					secondSet.Add(value2);
				}
			}
			
			dgvContingencia.Columns.Add("Total", "Total");
			dgvContingencia.Rows[secondSet.Count].Cells[0].Value = "Total";
			
			float [, ] matrizFrecuencia = new float[secondSet.Count + 1, firstSet.Count + 1];
			float [, ] frecuenciasEsperadas = new float[secondSet.Count, firstSet.Count];
			
			for (int i = 0; i < dgvBivariable.Rows.Count - 1; i++) 
			{
				string value1 = dgvBivariable.Rows[i].Cells[0].Value.ToString();
				string value2 = dgvBivariable.Rows[i].Cells[1].Value.ToString();
				
				int columna = firstSet.IndexOf(value1);
				int fila = secondSet.IndexOf(value2);
				matrizFrecuencia[fila, columna] = matrizFrecuencia[fila, columna] + 1;
			}
			
			for (int i = 0; i < firstSet.Count; i++) 
			{
				float suma = 0;
				for (int j = 0; j < secondSet.Count; j++)
				{
					suma += matrizFrecuencia[j, i];
				}
				matrizFrecuencia[secondSet.Count, i] = suma;
			}
			
			float sumaTotal = 0;
			for (int i = 0; i < secondSet.Count; i++) 
			{
				float suma = 0;
				for (int j = 0; j < firstSet.Count; j++)
				{
					suma += matrizFrecuencia[i, j];
				}
				sumaTotal += suma;
				matrizFrecuencia[i, firstSet.Count] = suma;
			}
			matrizFrecuencia[secondSet.Count, firstSet.Count] = sumaTotal;
			
			for (int i = 0; i < firstSet.Count + 1; i++) 
			{
				for (int j = 0; j < secondSet.Count + 1; j++) 
				{
					dgvContingencia.Rows[j].Cells[i + 1].Value = Convert.ToString(matrizFrecuencia[j, i]);
				}
			}
			
			float chiCuadrada = 0;
			for (int i = 0; i < secondSet.Count; i++)
			{
				for (int j = 0; j < firstSet.Count; j++)
				{
					float totalColumna = matrizFrecuencia[secondSet.Count, j];
					float totalFila = matrizFrecuencia[i, firstSet.Count];
					frecuenciasEsperadas[i, j] = (totalColumna * totalFila) / sumaTotal;
					chiCuadrada += ((matrizFrecuencia[i, j] - frecuenciasEsperadas[i, j]) * (matrizFrecuencia[i, j] - frecuenciasEsperadas[i, j])) / frecuenciasEsperadas[i, j];
				}
			}
			float coeficienteContingencia;
			coeficienteContingencia = (float)Math.Sqrt(chiCuadrada / (sumaTotal * Math.Sqrt((firstSet.Count - 1) * (secondSet.Count - 1))));
			KeyValuePair<float, float> pair = new KeyValuePair<float, float>(coeficienteContingencia, chiCuadrada);
			return pair;
		}
		
		//Se calcula con la función el coeficiente R de pearson
		public static float calcularCoeficientePearson(DataGridView dgvDatos, DataGridView dgvBivariable, int index1, int index2, string valorFaltante)
		{
			float media1 = TendenciaCentral.mediaNumericos(dgvDatos, index1, valorFaltante);
			float media2 = TendenciaCentral.mediaNumericos(dgvDatos, index2, valorFaltante);
			float desviacion1 = TendenciaCentral.desviacionEstandar(dgvDatos, index1, valorFaltante);
			float desviacion2 = TendenciaCentral.desviacionEstandar(dgvDatos, index2, valorFaltante);
			float sumatoria = 0;
			float n = dgvBivariable.Rows.Count - 1;
			
			for (int i = 0; i < n; i++)
			{
				string value1 = dgvBivariable.Rows[i].Cells[0].Value.ToString();
				string value2 = dgvBivariable.Rows[i].Cells[1].Value.ToString();
				if (!string.IsNullOrEmpty(value1) && !string.IsNullOrEmpty(value2) && value1 != valorFaltante && value2 != valorFaltante)
					sumatoria += (Convert.ToSingle(dgvBivariable.Rows[i].Cells[0].Value.ToString()) - media1) * 
							 (Convert.ToSingle(dgvBivariable.Rows[i].Cells[1].Value.ToString()) - media2);
			}
			
			sumatoria = sumatoria / (n * desviacion1 * desviacion2);
			return sumatoria;
		}	
	}
}
