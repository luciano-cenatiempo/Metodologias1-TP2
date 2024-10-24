/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 23/10/2024
 * Hora: 19:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace TP2
{
	/// <summary>
	/// Description of Conjunto.
	/// </summary>
	public class Conjunto : Coleccionable, Iterable
	{
		private List<Comparable> elementos;
		public Conjunto()
		{
			elementos = new List<Comparable>();
		}
		
		
		public List<Comparable> getElementos(){
			return this.elementos;
		}
		
		public int cuantos()
		{
			return this.elementos.Count;
		}
		public Comparable minimo()
		{
			Comparable min = elementos[0];
			for (int i = 1; i < elementos.Count; i++) {
				if (elementos[i].sosMenor(min)) {
					min = elementos[i];
				}
			}
			return min;
		}
		public Comparable maximo()
		{
			Comparable max = elementos[0];
			for (int i = 1; i < elementos.Count; i++) {
				if (elementos[i].sosMayor(max)) {
					max = elementos[i];
				}
			}
			return max;
		}
		public void agregar(Comparable com)
		{
			if (!pertenece(com)) {
				this.elementos.Add(com);
			}
			
		}
		public bool contiene(Comparable com)
		{
			foreach (Comparable el in elementos){
				if (com.sosIgual(el)) {
					return true;
				}
			}
			return false;
		}
		
		// metodo pertenece
		public bool pertenece(Comparable com){
			return contiene(com);
			
		}
		
		
		#region Iterable implementation
		public Iterador crearIterador()
		{
			return new IteradorDeConjunto(this);
		}
		#endregion
	}
}
