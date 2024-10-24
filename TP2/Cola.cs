/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 11/9/2024
 * Hora: 08:52
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace TP2
{
	/// <summary>
	/// Description of Cola.
	/// </summary>
	public class Cola : Coleccionable, Iterable
	{
		private List<Comparable> elementos;
		
		public Cola()
		{
			this.elementos = new List<Comparable>();
		}
		
		public List<Comparable> getElementos(){
			return this.elementos;
		}
		
		public bool esVacia(){
			if(this.elementos.Count == 0){
				return true;
			}
			return false;
		}
		
		public void agregar(Comparable com){
			this.elementos.Add(com);
		}
		
		public Comparable desencolar(){
			if(!esVacia()){
				return elementos[0];
			}
			return null;
		}
		
		public int cuantos()
		{
			return elementos.Count;
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

		public bool contiene(Comparable com)
		{
			foreach (Comparable el in elementos){
				if (com.sosIgual(el)) {
					return true;
				}
			}
			return false;
		}

		#region Iterable implementation
		public Iterador crearIterador()
		{
			return new IteradorDeCola(this);
		}
		#endregion
	}
}
