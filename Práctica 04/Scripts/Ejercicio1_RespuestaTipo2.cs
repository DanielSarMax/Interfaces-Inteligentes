/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since October 2024
 * @description Respuesta tipo 2 a la colisión de un cubo con un cilindro
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_RespuestaTipo2 : MonoBehaviour {
  public Ejercicio1_Notificador notificadorColision;
  public GameObject ObjetoASeguir;
  public float speed;
  private Rigidbody _rigidbody;
  private bool _colisionDetectada = false;

  // Start is called before the first frame update
  void Start() {
    speed = 2;
    _rigidbody = GetComponent<Rigidbody>();
    notificadorColision.OnObjectCollision += () => _colisionDetectada = true;   
  }

  void FixedUpdate() {
    if (_colisionDetectada) {
      RespuestaTipo2();
    }
  }

  // Sigue al cilindro continuamente en respuesta a la colisión del cubo con el cilindro
  private void RespuestaTipo2() {
    Vector3 direccionObjetivo = ObjetoASeguir.transform.position - transform.position;
    _rigidbody.MovePosition(_rigidbody.position + direccionObjetivo.normalized * speed * Time.deltaTime);
  }
}
