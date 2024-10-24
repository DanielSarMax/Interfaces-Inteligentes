/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since October 2024
 * @description Notifica cuando un objeto se encuentra a una distancia determinada de otro
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_Notificador : MonoBehaviour {
  public GameObject objetivoDeReferencia;
  public float distanciaNotificacion = 2.0f;
  public delegate void NotificacionProximidad();
  public event NotificacionProximidad Notificar;

  void FixedUpdate() {
    if (objetivoDeReferencia != null) {
      float distancia = Vector3.Distance(transform.position, objetivoDeReferencia.transform.position);
      if (distancia <= distanciaNotificacion) {
        Notificar();
      }
    }
  }
}
