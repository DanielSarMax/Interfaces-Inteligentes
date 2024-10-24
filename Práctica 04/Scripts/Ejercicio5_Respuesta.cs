/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since October 2024
 * @description Respuesta ante la coliisión de un objeto
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_Respuesta : MonoBehaviour {
  public Ejercicio5_Notificador notificadorColision;

  void Start() {
    notificadorColision.NotificarColision += (GameObject objetoColisionado, int puntos) => {
      IncrementarPuntuacion(puntos);
      DesaparecerObjeto(objetoColisionado);
    };
  }

  private void IncrementarPuntuacion(int puntos) {
    Ejercicio5_Puntuacion.IncrementarPuntuacion(puntos);
  }

  private void OnDisable() {
    notificadorColision.NotificarColision -= (GameObject objetoColisionado, int puntos) => {
      Ejercicio5_Puntuacion.IncrementarPuntuacion(puntos);
    };
  }

  private void DesaparecerObjeto(GameObject objeto) {
    objeto.SetActive(false);
  }
}
