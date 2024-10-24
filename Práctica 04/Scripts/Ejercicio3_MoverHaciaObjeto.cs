/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since October 2024
 * @description Respuesta si el objeto colisiona con un objeto de un grupo específico
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_MoverHaciaObjeto : MonoBehaviour {
  public Ejercicio3_Notificador notificadorColision;
  public float speed;
  private bool _invocarRespuesta = false;
  private Rigidbody _rigidbody;
  private string tagDelGrupo;
  private GameObject objetoASeguir;

  void Start() {
    speed = 1;
    _rigidbody = GetComponent<Rigidbody>();
    notificadorColision.OnObjectCollision += (tag) => {
      _invocarRespuesta = true;
      tagDelGrupo = tag;
    };
    objetoASeguir = GameObject.FindGameObjectWithTag("ObjetoASeguir");
  }

  void FixedUpdate() {
    if (_invocarRespuesta) {
      Respuesta(tagDelGrupo);
    }
  }

  private void Respuesta(string tagDelGrupo) {
    if (tagDelGrupo == "SpiderTipo2") {
      Vector3 direccionObjetivo = objetoASeguir.transform.position - transform.position;
      // Rotación de la araña
      Quaternion rotacionObjetivo = Quaternion.LookRotation(direccionObjetivo);
      transform.rotation = Quaternion.Slerp(transform.rotation, rotacionObjetivo, 0.1f);
      _rigidbody.MovePosition(_rigidbody.position +
      direccionObjetivo.normalized * speed * Time.fixedDeltaTime);
    }
  }

  private void OnCollisionEnter(Collision other) {
    if (other.gameObject.tag == "ObjetoASeguir") {
      _invocarRespuesta = false;
    }
  }

  private void OnDisable() {
    notificadorColision.OnObjectCollision -= (tag) => {
      _invocarRespuesta = true;
      tagDelGrupo = tag;
    };
  }
}
