/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since October 2024
 * @description Notificador de colisiones según etiquetas
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_Notificador : MonoBehaviour {
  public delegate void NotificarColision(string tag);
  public event NotificarColision OnObjectCollision;
	public string[] tagsOnCollision;

  private void OnCollisionEnter(Collision other) {
    foreach (string tag in tagsOnCollision) {
			if (other.gameObject.tag == tag) {
				// Si no hay suscriptores, se lanzará una excepción
				OnObjectCollision?.Invoke(other.gameObject.tag);
			}
		}
  }
}