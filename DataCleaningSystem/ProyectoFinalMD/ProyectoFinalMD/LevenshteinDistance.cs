/*
 * Created by SharpDevelop.
 * User: diego
 * Date: 01/05/2019
 * Time: 07:34 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProyectoFinalMD
{
	/// <summary>
	/// Description of LevenshteinDistance.
	/// </summary>
	public static class LevenshteinDistance
	{
		public static int ObtenerDistancia(string palabra1, string palabra2) {
			
            if (palabra1.Length == 0 || palabra2.Length == 0) 
                return Math.Abs(palabra1.Length - palabra2.Length); 
 
            if (palabra1[0] == palabra2[0]) 
                return ObtenerDistancia(palabra1.Substring(1), palabra2.Substring(1)); 
 
            if (palabra1.Contains(palabra2))   
            { 
                palabra1 = palabra1.Replace(palabra2, String.Empty); 
                palabra2 = String.Empty; 
 
                return 1 + ObtenerDistancia(palabra1.Substring(1), palabra2); 
            } 
 
            if (palabra2.Contains(palabra1))   
            { 
                palabra2 = palabra2.Replace(palabra1, String.Empty); 
                palabra1 = String.Empty; 
                return 1 + ObtenerDistancia(palabra1, palabra2.Substring(1)); 
            } 
 
            return 1 + ObtenerDistancia(palabra1.Substring(1), palabra2.Substring(1)); 
        } 
	}
}
