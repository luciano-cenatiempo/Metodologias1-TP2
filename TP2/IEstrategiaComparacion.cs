/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 9/10/2024
 * Hora: 10:20
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP2
{
	/// <summary>
	/// Description of IEstrategiaComparacion.
	/// </summary>
	public interface IEstrategiaComparacion
	{
		bool sosMayor(Alumno a1, Alumno a2);
		bool sosMenor(Alumno a1, Alumno a2);
		bool sosIgual(Alumno a1, Alumno a2);
		
	}
}
