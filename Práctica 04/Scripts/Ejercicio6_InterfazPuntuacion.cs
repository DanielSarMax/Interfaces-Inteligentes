/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since October 2024
 * @description Despliega la interfaz de puntuación usando el componente texto.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6_InterfazPuntuacion : MonoBehaviour {
  public TMPro.TextMeshProUGUI textoPuntuacion;

  void Start() {
    Ejercicio5_Puntuacion.ReiniciarPuntuacion();
  }

  void Update() {
    textoPuntuacion.text = "Puntuación: " + Ejercicio5_Puntuacion.ObtenerPuntuacion();
  }
}
