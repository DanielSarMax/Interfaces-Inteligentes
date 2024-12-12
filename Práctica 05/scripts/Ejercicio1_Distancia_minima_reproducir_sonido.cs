/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since Diciembre 2024
 * @description Cuando el objeto se encuentra a una distancia mínima de otro objeto,
 *              se reproducirá un sonido.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class Ejercicio1_Distancia_minima_reproducir_sonido : MonoBehaviour {
  public AudioClip sonido_a_reproducir;
  public GameObject objeto_objetivo;
  private bool _invocarRespuesta = true;
  private Timer _timer;

  void Start() {
    _timer = new Timer(5000); // Establece el intervalo de tiempo en milisegundos
    _timer.Elapsed += OnTimedEvent;
    _timer.AutoReset = false; // Se establece en false para que no se repita
  }

  void Update() {
    if (_invocarRespuesta) {
      if (Vector3.Distance(transform.position, objeto_objetivo.transform.position) < 1) {
        if (sonido_a_reproducir != null) {
          AudioSource.PlayClipAtPoint(sonido_a_reproducir, transform.position);
        }
        _invocarRespuesta = false;
        _timer.Start();
      }
    }
  }

  // Método que se ejecuta cuando el tiempo del timer ha terminado
  private void OnTimedEvent(object source, ElapsedEventArgs e) {
    _invocarRespuesta = true;
    _timer.Stop();
  }
}
