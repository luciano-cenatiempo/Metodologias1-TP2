/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 9/10/2024
 * Hora: 10:46
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP2
{
	/// <summary>
	/// Description of PorLegajo.
	/// </summary>
	public class PorLegajo : IEstrategiaComparacion
	{
		public PorLegajo()
		{
		}
		
		public bool sosIgual(Alumno a1, Alumno a2){
			return a1.getLegajo() == a2.getLegajo();
		}
		
		public bool sosMayor(Alumno a1, Alumno a2){
			return a1.getLegajo() > a2.getLegajo();
		}
		
		public bool sosMenor(Alumno a1, Alumno a2){
			return a1.getLegajo() < a2.getLegajo();
		}
		
	}
}
