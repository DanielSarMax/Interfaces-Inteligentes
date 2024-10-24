/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since October 2024
 * @description Respuesta tipo 1 a la colisión de un cubo con un cilindro
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_RespuestaTipo1 : MonoBehaviour {
  public Ejercicio1_Notificador notificadorColision;
  public GameObject ObjetoASeguir;
  public float speed;
  private bool _colisionDetectada = false;
  private Rigidbody _rigidbody;

  void Start() {
    speed = 2;
    _rigidbody = GetComponent<Rigidbody>();
    notificadorColision.OnObjectCollision += () => _colisionDetectada = true; 
  }

  void FixedUpdate() {
    if (_colisionDetectada) {
      RespuestaTipo1();
    }
  }

  // Sigue a la esfera tipo 1 en respuesta a la colisión del cubo con el cilindro
  private void RespuestaTipo1() {
    Vector3 direccionObjetivo = ObjetoASeguir.transform.position - transform.position;
    _rigidbody.MovePosition(_rigidbody.position + direccionObjetivo.normalized * speed * Time.deltaTime);
  }
}
