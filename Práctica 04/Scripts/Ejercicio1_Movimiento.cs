/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since October 2024
 * @description Permite el movimiento de un objeto con Rigidbody
 *              con las teclas de dirección
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_Movimiento : MonoBehaviour {
  public float speed;
  private Rigidbody _rigidbody;
  // Start is called before the first frame update
  void Start() {
    speed = 2;
    _rigidbody = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void FixedUpdate() {
    if (Input.GetKey(KeyCode.UpArrow)) {
      _rigidbody.MovePosition(_rigidbody.position + Vector3.forward * speed * Time.deltaTime);
    }
    else if (Input.GetKey(KeyCode.DownArrow)) {
      _rigidbody.MovePosition(_rigidbody.position - Vector3.forward * speed * Time.deltaTime);
    }
    else if (Input.GetKey(KeyCode.LeftArrow)) {
      _rigidbody.MovePosition(_rigidbody.position - Vector3.right * speed * Time.deltaTime);
    }
    else if (Input.GetKey(KeyCode.RightArrow)) {
      _rigidbody.MovePosition(_rigidbody.position + Vector3.right * speed * Time.deltaTime);
    }
  }
}
