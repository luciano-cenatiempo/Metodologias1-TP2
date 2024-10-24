/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 18/9/2024
 * Hora: 12:22
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP2
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona : Comparable
	{
		protected string nombre;
		protected int dni;
		public Persona()
		{
		}
		
		public Persona(string n, int d){
			this.nombre = n;
			this.dni = d;
		}
		
		public string getNombre(){
			return this.nombre;
		}
		
		public int getDni(){
			return this.dni;
		}
		
		public virtual bool sosIgual(Comparable com){
			return this.dni == ((Persona)com).getDni();
		}
		public virtual bool sosMenor(Comparable com){
			return this.dni < ((Persona)com).getDni();
		}
		public virtual bool sosMayor(Comparable com){
			return this.dni > ((Persona)com).getDni();
		}
		
		public override string ToString(){
			return this.getNombre() + "-" + this.getDni().ToString() ;
		}
	}
}
