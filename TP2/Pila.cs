﻿/*
 * Creado por SharpDevelop.
 * Usuario: luciano.cenatiempo
 * Fecha: 3/9/2024
 * Hora: 15:19
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System.Collections.Generic;
using System;


namespace TP2
{
	/// <summary>
	/// Description of Pila.
	/// </summary>
	public class Pila : Coleccionable, Iterable
	{
		private List<Comparable> elementos;
		
		
		public Pila()
		{
			this.elementos = new List<Comparable>();
		}
		
		public List<Comparable> getElementos(){
			return this.elementos;
		}
		
		public void agregar(Comparable com){
			this.elementos.Add(com);
		}
		
		public bool esVacia(){
			if(this.elementos.Count == 0){
				return true;
			}
			return false;
		}
		
		public Comparable desapilar(){
			if(!this.esVacia()){
				Comparable aux = this.elementos[this.elementos.Count-1];
				this.elementos.Remove(elementos[elementos.Count - 1]);
				return aux;
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
			return new IteradorDePila(this);
		}
		#endregion
	}
}
