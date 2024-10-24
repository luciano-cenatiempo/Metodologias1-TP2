/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 9/10/2024
 * Hora: 10:27
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP2
{
	/// <summary>
	/// Description of PorNombre.
	/// </summary>
	public class PorNombre : IEstrategiaComparacion
	{
		public PorNombre()
		{
		}
		
		public bool sosIgual(Alumno a1, Alumno a2){
			return a1.getNombre().Equals(a2.getNombre());
		}
		
		public bool sosMayor(Alumno a1, Alumno a2){
			int comparar = String.Compare(a1.getNombre(), a2.getNombre(), comparisonType: StringComparison.OrdinalIgnoreCase);
			return comparar > 0;
		}
		
		public bool sosMenor(Alumno a1, Alumno a2){
			int comparar = String.Compare(a1.getNombre(), a2.getNombre(), comparisonType: StringComparison.OrdinalIgnoreCase);
			return comparar < 0;
		}
	}
}
