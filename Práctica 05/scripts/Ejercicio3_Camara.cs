/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since Diciembre 2024
 * @description Nos permite reproducir lo que capta la 
 *              cámara en un objeto (a través de su material).
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_Camara : MonoBehaviour {
  private WebCamTexture _webCamTexture;
  private int captureCounter = 0;

  void Start() {
    Renderer material = GetComponent<Renderer>();
    if (WebCamTexture.devices.Length > 0) {
      _webCamTexture = new WebCamTexture(WebCamTexture.devices[0].name);
      Debug.Log("Cámara seleccionada: " + WebCamTexture.devices[0].name);
    } else {
      Debug.LogError("No hay cámaras disponibles.");
      return;
    }
    material.material.mainTexture = _webCamTexture;
  }

  void Update() {
    if (_webCamTexture == null) return;
    if (Input.GetKeyDown(KeyCode.S)) {
      StartCamara();
    } else if (Input.GetKeyDown(KeyCode.P)) {
      StopCamara();
    } else if (Input.GetKeyDown(KeyCode.X) && _webCamTexture.isPlaying) {
      TakeSnapshot();
    }
  }

  private void StartCamara() {
    if (!_webCamTexture.isPlaying) _webCamTexture.Play();
  }

  private void StopCamara() {
    if (_webCamTexture.isPlaying) _webCamTexture.Stop();
  }

  private void TakeSnapshot() {
    Texture2D snapshot = new Texture2D(_webCamTexture.width, _webCamTexture.height);
    snapshot.SetPixels(_webCamTexture.GetPixels());
    snapshot.Apply();
    byte[] bytes = snapshot.EncodeToPNG();
    string path = Application.dataPath + "/Snapshots/Snapshot_" + captureCounter + ".png";
    System.IO.File.WriteAllBytes(path, bytes);
    Debug.Log("La captura ha sido almacenada en: " + path);
    captureCounter++;
  }
}
