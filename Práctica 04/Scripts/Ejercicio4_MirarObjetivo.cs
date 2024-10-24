/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since October 2024
 * @description Funcionalidad para que un objeto mire a otro en respuesta a un evento
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_MirarObjetivo : MonoBehaviour {
  public GameObject objetivoAMirar;
  public float velocidadGiro = 1.0f;
  public Ejercicio4_Notificador notificadorProximidad;
  private bool _eventoActivado = false;
  private Rigidbody _rigidbody;

  void Start() {
    notificadorProximidad.Notificar += () => _eventoActivado = true;
    _rigidbody = GetComponent<Rigidbody>();
  }

  void FixedUpdate() {
    if (_eventoActivado) {
      MirarObjetivo();
    }
  }

  private void MirarObjetivo() {
    if (objetivoAMirar != null) {
      Vector3 direccionObjetivo = (objetivoAMirar.transform.position - transform.position).normalized;
      direccionObjetivo.y = 0;
      Quaternion rotacionObjetivo = Quaternion.LookRotation(direccionObjetivo);
      _rigidbody.MoveRotation(Quaternion.Slerp(_rigidbody.rotation, rotacionObjetivo, velocidadGiro * Time.fixedDeltaTime));
    }
  }

  private void OnDisable() {
    notificadorProximidad.Notificar -= () => _eventoActivado = true;
  }
}
