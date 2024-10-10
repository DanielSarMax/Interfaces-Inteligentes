/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since September 2024
 * @description Script that changes the color of an object every X frames
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
  public double FrameInterval = 120; // We need to see this variable in the inspector
  private double _frameCounter = 0;
  private Color _color;
  private Renderer _renderer;

  // Start is called before the first frame update
  void Start() {
    _renderer = GetComponent<Renderer>(); // Get the renderer component to change the color
    ChangeColor();
  }

  // Update is called once per frame
  void Update() {
    _frameCounter += 1;
    if (_frameCounter >= FrameInterval) {
      _frameCounter = 0;
      ChangeColor();
    }
  }

  // Change the color of the object
  void ChangeColor() {
    int rgbValue = Random.Range(0, 3); // Random value between 0 and 2
    _color[rgbValue] = Random.value; // Random value between 0 and 1
    _renderer.material.color = _color;
  }
}
