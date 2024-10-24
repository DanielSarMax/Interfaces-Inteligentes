/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since October 2024
 * @description Funcionalidad para que un objeto se 
 *              teletransporte a otro en respuesta a un evento
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_Teletransporte : MonoBehaviour {
  public GameObject objetivoDestino;
  private Rigidbody _rigidbody;
  public Ejercicio4_Notificador notificadorProximidad;
  private bool _eventoActivado = false;

  void Start() {
    _rigidbody = GetComponent<Rigidbody>();
    notificadorProximidad.Notificar += () => _eventoActivado = true;
  }

  void FixedUpdate() {
    if (_eventoActivado && CalcularDistancia() > 2.0f) {
      TeletransportarAObjetivo();
    }
  }

  private void TeletransportarAObjetivo() {
    if (objetivoDestino != null) {
      Vector3 direccionObjetivo = (objetivoDestino.transform.position - transform.position).normalized;
      direccionObjetivo.y = 0;
      _rigidbody.MovePosition(transform.position + direccionObjetivo * 2.0f);
    }
  }

  private float CalcularDistancia() {
    return Vector3.Distance(_rigidbody.position, objetivoDestino.transform.position);
  }

  private void OnDisable() {
    notificadorProximidad.Notificar -= () => _eventoActivado = true;
  }
}
