/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since September 2024
 * @description Script that changes the color of an object if the player presses the selected key
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangerKey : MonoBehaviour {
  public KeyCode _changeColorKey = KeyCode.C; // Key to change the color of the object
  private Renderer _renderer; // Variable to store the renderer of the object

  // Start is called before the first frame update
  void Start() {
    _renderer = GetComponent<Renderer>();
  }

  // Update is called once per frame
  void Update() {
    // Check if the key to change the color is pressed
    if (Input.GetKeyDown(_changeColorKey)) {
      Debug.Log("The key " + _changeColorKey + " was pressed");
      ChangeColor();
    }
  }

  // Changes the color of the object
  void ChangeColor() {
    // Change the color of the object to a random color
    _renderer.material.color = new Color(Random.value, Random.value, Random.value);
  }
}
