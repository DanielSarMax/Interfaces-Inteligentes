/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since October 2024
 * @description Notifica cuando el objeto ha colisionado con otro
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_Notificador : MonoBehaviour {
  public string[] tagsObjetivos;
  private Dictionary<string, int> mapaTagPuntos = new Dictionary<string, int> {
    { "HuevoTipo1", 5 },
    { "HuevoTipo2", 100 }
  };
  public delegate void NotificacionColision(GameObject objetoColisionado, int puntos);
  public event NotificacionColision NotificarColision;
  private Rigidbody _rigidbody;

  void Start() {
    _rigidbody = GetComponent<Rigidbody>();
    tagsObjetivos = new string[] { "HuevoTipo1", "HuevoTipo2" };
  }

  private void OnCollisionEnter(Collision collision) {
    foreach (string tag in tagsObjetivos) {
      if (collision.gameObject.CompareTag(tag)) {
        NotificarColision(collision.gameObject, mapaTagPuntos[tag]);
      }
    }
  }
}
