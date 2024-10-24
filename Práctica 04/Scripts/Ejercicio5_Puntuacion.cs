/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since October 2024
 * @description Gestiona la puntuación del jugador
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_Puntuacion : MonoBehaviour {
  private static int _puntuacion = 0;

  public static void IncrementarPuntuacion(int puntos) {
    _puntuacion += puntos;
    ImprimirPuntuacion();
  }

  private static void ImprimirPuntuacion() {
    Debug.Log("Puntuación: " + _puntuacion);
  }

  public static void ReiniciarPuntuacion() {
    _puntuacion = 0;
    ImprimirPuntuacion();
  }

  public static int ObtenerPuntuacion() {
    return _puntuacion;
  }

  public static void SetPuntuacion(int puntuacion) {
    _puntuacion = puntuacion;
  }
}
