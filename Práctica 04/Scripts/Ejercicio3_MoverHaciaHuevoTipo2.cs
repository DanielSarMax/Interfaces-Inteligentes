/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since October 2024
 * @description Respuesta si un objeto colisiona con un objeto con tag "SpiderTipo1"
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_MoverHaciaHuevoTipo2 : MonoBehaviour {
  public Ejercicio3_Notificador notificadorColision;
  public float speed;
  private bool _invocarRespuesta = false;
  private Rigidbody _rigidbody;
  private string tagDelGrupo;
  private GameObject _huevoAleatorio;

  void Start() {
    speed = 1;
    _rigidbody = GetComponent<Rigidbody>();
    notificadorColision.OnObjectCollision += (tag) => {
      _invocarRespuesta = true;
      tagDelGrupo = tag;
    };
    GameObject[] HuevoTipo2 = GameObject.FindGameObjectsWithTag("HuevoTipo2");
    _huevoAleatorio = HuevoTipo2[Random.Range(0, HuevoTipo2.Length)];
  }

  void FixedUpdate() {
    if (_invocarRespuesta) {
      Respuesta(tagDelGrupo);
    }
  }

  // Las SpiderTipo1 se mueve hacia uno de los objetos con tag "HuevoTipo2"
  private void Respuesta(string tagDelGrupo) {
    if (tagDelGrupo == "SpiderTipo1") {
      Vector3 direccionObjetivo = _huevoAleatorio.transform.position - transform.position;
      Quaternion rotacionObjetivo = Quaternion.LookRotation(direccionObjetivo);
      transform.rotation = Quaternion.Slerp(transform.rotation, rotacionObjetivo, 0.1f);
      _rigidbody.MovePosition(_rigidbody.position +
      direccionObjetivo.normalized * speed * Time.fixedDeltaTime);
    }
  }

  private void OnCollisionEnter(Collision other) {
    if (other.gameObject.tag == "HuevoTipo2") {
      _invocarRespuesta = false;
      ChangeColor();
    }
  }

  private void ChangeColor() {
    GetComponentInChildren<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
  }

  private void OnDisable() {
    notificadorColision.OnObjectCollision -= (tag) => {
      _invocarRespuesta = true;
      tagDelGrupo = tag;
    };
  }
}
