/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since Diciembre 2024
 * @description Al pulsar la tecla R, inicia la recogida de audio por el micrófono, 
 *              si se pulsa de nuevo, se detiene y se reproduce el clip de audio.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_Reproducir_sonido_microfono : MonoBehaviour {
  private AudioClip _grabacion;
  private AudioSource _audioSource;
  private string _microfono;

  void Start() {
    _audioSource = GetComponent<AudioSource>();
    if (Microphone.devices.Length > 0) {
      _microfono = Microphone.devices[0];
    } else {
      Debug.LogError("No hay micrófonos disponibles.");
    }
  }

  void Update() {
    if (_microfono == null) return;
    if (Input.GetKeyDown(KeyCode.R)) {
      if (!Microphone.IsRecording(_microfono)) {
        EmpezarGrabacion();
      } else {
        PararGrabacion();
      }
    }
  }

  private void EmpezarGrabacion() {
    if (!Microphone.IsRecording(_microfono)) {
      // Se graba durante 10 segundos a 44100 Hz
      _grabacion = Microphone.Start(_microfono, false, 10, 44100);
    }
  }

  private void PararGrabacion() {
    if (Microphone.IsRecording(_microfono)) {
      Microphone.End(_microfono);
      ReproducirAudio();
    }
  }

  private void ReproducirAudio() {
    _audioSource.clip = _grabacion;
    _audioSource.Play();
  }
}