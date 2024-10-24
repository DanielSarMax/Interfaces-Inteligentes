/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since October 2024
 * @description Gestiona la puntuación del jugador y 
 *              notifica cuando se alcanzan 100 puntos
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_NotificadorPuntuacion : MonoBehaviour {
  public delegate void Notificacion100Puntos();
  public event Notificacion100Puntos Recompensa100Puntos;
  private int _ultimaPuntuacion = 0;

  void FixedUpdate() {
    int puntuacionActual = Ejercicio5_Puntuacion.ObtenerPuntuacion();
    if (puntuacionActual / 100 > _ultimaPuntuacion / 100) {
        Recompensa100Puntos();
    }
    _ultimaPuntuacion = puntuacionActual;
  }
}