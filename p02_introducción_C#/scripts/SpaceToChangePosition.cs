/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since September 2024
 * @description Script that changes the position of the object when the space key is pressed
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceToChangePosition : MonoBehaviour {
  private Vector3[] _positions = new Vector3[3];
  private int _currentPosition = 0;

  // Initializes the _positions of the object
  void Start() {
    _positions[0] = GameObject.FindWithTag("Position1").transform.position;
    _positions[1] = GameObject.FindWithTag("Position2").transform.position;
    _positions[2] = GameObject.FindWithTag("Position3").transform.position;
  }

  // When the space key is pressed, change the position of the object
  void Update() {
    // Check if the space key is pressed
    if (Input.GetKeyDown(KeyCode.Space)) {
      ChangePosition();
    }
  }

  // Changes the position of the object
  void ChangePosition() {
    // Change the position of the object to the next position in the array
    transform.position = _positions[_currentPosition];
    // Update the current position
    _currentPosition = (_currentPosition + 1) % _positions.Length;
  }
}
