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

public class Ejercicio7_RespuestaRecompensa : MonoBehaviour {
  public TMPro.TextMeshProUGUI textoPuntuacion;
  private bool _mostarRecompensa = false;
  public Ejercicio7_NotificadorPuntuacion notificadorPuntuacion;
  public Ejercicio5_Notificador notificadorColision;

  void Start() {
    notificadorPuntuacion.Recompensa100Puntos += () => _mostarRecompensa = true;
    notificadorColision.NotificarColision += (GameObject objetoColisionado, int puntos) => {
      IncrementarPuntuacion(puntos);
      DesaparecerObjeto(objetoColisionado);
    };
  }

  void FixedUpdate() {
    if (_mostarRecompensa) {
      MostrarRecompensa();
    } else {
      OcultarRecompensa();
    }
    if (Input.GetKeyDown(KeyCode.R)) {
      OcultarRecompensa();
    }
  }

  public void MostrarRecompensa() {
    textoPuntuacion.text = "¡Recompensa!";
  }

  public void OcultarRecompensa() {
    _mostarRecompensa = false;
    textoPuntuacion.text = "";
  }

  void OnDisable() {
    notificadorPuntuacion.Recompensa100Puntos -= () => _mostarRecompensa = true;
    notificadorColision.NotificarColision -= (GameObject objetoColisionado, int puntos) => {
      IncrementarPuntuacion(puntos);
      DesaparecerObjeto(objetoColisionado);
    };
  }

  private void IncrementarPuntuacion(int puntos) {
    Ejercicio5_Puntuacion.IncrementarPuntuacion(puntos);
  }

  private void DesaparecerObjeto(GameObject objeto) {
    objeto.SetActive(false);
  }
}
