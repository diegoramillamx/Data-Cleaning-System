using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFinalMD
{
	public static class TendenciaCentral
	{
		public static float mediaNumericos(DataGridView dgvDatos, int index, string valorFaltante)
		{
			float media, suma=0;
			for (int i = 0; i < dgvDatos.Rows.Count - 1; i++) 
			{
				string valor = dgvDatos.Rows[i].Cells[index].Value.ToString();
				if (!string.IsNullOrEmpty(valor) && valor != valorFaltante)
					suma += Convert.ToSingle(valor);				
			}
			media = suma / (dgvDatos.Rows.Count - 1);
			return media;
		}
		
		public static float modaNumericos(DataGridView dgvDatos, int _index, string valorFaltante)
		{
			List<float> items = new List<float>();
			for (int i = 0; i < dgvDatos.Rows.Count - 1; i++) 
			{
				string valor = dgvDatos.Rows[i].Cells[_index].Value.ToString();
				if (!string.IsNullOrEmpty(valor) && valor != valorFaltante)
					items.Add(Convert.ToSingle(valor));
			}
			items.Sort();
			
			List<float> keys = new List<float>();
			List<int> values = new List<int>();
			float item;
			
			for (int i = 0; i < items.Count; i++)
			{
				item = items[i];
				if (keys.Contains(item))
				{
					int index = keys.BinarySearch(item);
					values[index] = values[index] + 1;
				}
				else 
				{
					keys.Add(item);
					values.Add(0);
				}
			}
			
			int indexModa = 0;
			int _valor = values[0];
			for (int i = 1; i < values.Count; i++)
			{
				if (values[i] > _valor)
				{
					_valor = values[i];
					indexModa = i;
				}
			}
			return keys[indexModa];
		}
		
		public static float medianaNumericos(DataGridView dgvDatos, int index, string valorFaltante)
		{
			List<float> items = new List<float>();
			for (int i = 0; i < dgvDatos.Rows.Count - 1; i++) 
			{
				string valor = dgvDatos.Rows[i].Cells[index].Value.ToString();
				if (!string.IsNullOrEmpty(valor) && valor != valorFaltante)
					items.Add(Convert.ToSingle(valor));
			}
			items.Sort();
			
			if (items.Count % 2 == 0) return items[items.Count / 2];
			return (items[items.Count / 2] + items[(items.Count / 2) + 1]) / 2;
		}
		
		public static float desviacionEstandar(DataGridView dgvDatos, int index, string valorFaltante)
		{
			float sumatoria = 0;
			float media = mediaNumericos(dgvDatos, index, valorFaltante);
			float n = dgvDatos.Rows.Count - 1;
			
			for (int i = 0; i < n; i++) 
			{
				string valor = dgvDatos.Rows[i].Cells[index].Value.ToString();
				if (!string.IsNullOrEmpty(valor) && valor != valorFaltante)
					sumatoria += (float)Math.Pow((Convert.ToSingle(valor) - media), 2);
			}
			sumatoria = (float)Math.Sqrt((sumatoria / n));
			return sumatoria;
		}
	
		public static string modaCategoricos(DataGridView dgvDatos, DataGridView dgvFrecuencia, int _index)
		{			
			List<string> items = new List<string>();
			for (int i = 0; i < dgvDatos.Rows.Count - 1; i++) 
			{
				items.Add(dgvDatos.Rows[i].Cells[_index].Value.ToString());
			}
			items.Sort();
			
			List<string> keys = new List<string>();
			List<int> values = new List<int>();
			string item;
			
			for (int i = 0; i < items.Count; i++)
			{
				item = items[i];
				if (keys.Contains(item))
				{
					int index = keys.BinarySearch(item);
					values[index] = values[index] + 1;
				}
				else 
				{
					dgvFrecuencia.Columns.Add(item, item);
					keys.Add(item);
					values.Add(1);
				}
			}
			
			int indexModa = 0;
			int valor = values[0];
			for (int i = 1; i < values.Count; i++)
			{
				if (values[i] > valor)
				{
					valor = values[i];
					indexModa = i;
				}
			}						
			
			dgvFrecuencia.Rows.Add(1);
			for (int i = 0; i < values.Count; i++) 
			{
				dgvFrecuencia.Rows[0].Cells[i].Value = values[i].ToString();
			}
			
			return Convert.ToString(keys[indexModa]);
		}
		
		public static string medianaCategoricos(DataGridView dgvDatos, int index)
		{
			List<string> items = new List<string>();
			for (int i = 0; i < dgvDatos.Rows.Count - 1; i++) 
			{
				items.Add(dgvDatos.Rows[i].Cells[index].Value.ToString());
			}
			items.Sort();			
			return Convert.ToString(items[items.Count / 2]);
		}
	}
}
