using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace ProyectoFinalMD
{
	public static class Normalizaciones
	{
		/* 
		 Funciones para normalizar los atributos numericos.
		 */
		public static void min_max(DataGridView dgvDatos, int index, int min, int max, int newMin, int newMax)
		{			
			List<double> listaDesordenada = new List<double>();
			
			for (int i = 0; i < dgvDatos.Rows.Count - 1; i++)
			{
				listaDesordenada.Add(Convert.ToSingle(dgvDatos.Rows[i].Cells[index].Value.ToString()));
			}
			
			for (int i = 0; i < dgvDatos.Rows.Count - 1; i++)
			{	
				double normalized = ((listaDesordenada[i] - min) / (max - min)) * (newMax-newMin) + newMin;
				dgvDatos.Rows[i].Cells[index].Value = normalized;
			}			
		}
		
		public static void zScore(DataGridView dgvDatos, int index, string valorFaltante)
		{
			List<double> listadesordenada = new List<double>();
			for (int i = 0; i < dgvDatos.Rows.Count - 1; i++)
			{
				listadesordenada.Add(Convert.ToSingle(dgvDatos.Rows[i].Cells[index].Value.ToString()));
			}
			double desviacion = Convert.ToDouble(TendenciaCentral.desviacionEstandar(dgvDatos, index, valorFaltante));
			double media = Convert.ToDouble(TendenciaCentral.mediaNumericos(dgvDatos, index, valorFaltante));
			for (int i = 0; i < dgvDatos.Rows.Count - 1; i++)
			{	
				double normalized = (listadesordenada[i] - media) / desviacion;
				dgvDatos.Rows[i].Cells[index].Value = normalized;
			}	
		}
		
		public static void zScoreAbsoluta(DataGridView dgvDatos, int index, string valorFaltante)
		{
			List<double> lista = new List<double>();
			for (int i = 0; i < dgvDatos.Rows.Count - 1; i++)
			{
				lista.Add(Convert.ToSingle(dgvDatos.Rows[i].Cells[index].Value.ToString()));
			}
			double desviacion = Convert.ToDouble(TendenciaCentral.desviacionEstandar(dgvDatos, index, valorFaltante));
			double media = Convert.ToDouble(TendenciaCentral.mediaNumericos(dgvDatos, index, valorFaltante));
			double normalizacion=0,normalized=0;
			double contador = dgvDatos.Rows.Count -1; 
			for (int i = 0; i < dgvDatos.Rows.Count - 1; i++)
			{
				normalizacion = normalizacion + Math.Abs(lista[i]-media);
			}
			for (int i = 0; i < dgvDatos.Rows.Count - 1; i++)
			{
				normalized = (lista[i]-media)/(1/contador*(normalizacion));
				dgvDatos.Rows[i].Cells[index].Value = normalized;
			}
		}
	}
}
