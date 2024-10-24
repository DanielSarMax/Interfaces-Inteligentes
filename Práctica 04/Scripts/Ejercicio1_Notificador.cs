/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since October 2024
 * @description Notificador de colisiones con cubos
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_Notificador : MonoBehaviour {
  public delegate void NotificarColision();
  public event NotificarColision OnObjectCollision;

  private void OnCollisionEnter(Collision other) {
    if (other.gameObject.tag == "Cubo") {
      // Si no hay suscriptores, se lanzará una excepción
      OnObjectCollision?.Invoke();
    }
  }
}
