/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since Diciembre 2024
 * @description Se moverá hacia un objeto específico, hasta que este colisione con él.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_Mover_hacia_objeto : MonoBehaviour {
  public float speed;
  private bool _invocarRespuesta = false;
  private Rigidbody _rigidbody;
  public GameObject objetoASeguir;

  void Start() {
    speed = 1;
    _rigidbody = GetComponent<Rigidbody>();
    _invocarRespuesta = true;
  }

  void FixedUpdate() {
    if (_invocarRespuesta) {
      Respuesta();
    }
  }

  private void Respuesta() {
    // Si nos encontramos a una distancia menor a 0.1, no se mueve
    if (Vector3.Distance(transform.position, objetoASeguir.transform.position) < 1) {
      _invocarRespuesta = false;
      return;
    }
    Vector3 direccionObjetivo = objetoASeguir.transform.position - transform.position;
    // Rotación de la araña
    Quaternion rotacionObjetivo = Quaternion.LookRotation(direccionObjetivo);
    transform.rotation = Quaternion.Slerp(transform.rotation, rotacionObjetivo, 0.1f);
    _rigidbody.MovePosition(_rigidbody.position +
    direccionObjetivo.normalized * speed * Time.fixedDeltaTime);
  }
}
