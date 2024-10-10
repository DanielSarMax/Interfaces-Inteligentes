/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since September 2024
 * @description Script that shows the magnitude, angle, distance and the tallest vector
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorInfo : MonoBehaviour {
  public Vector3 VectorA = new Vector3(0, 0, 0);
  public Vector3 VectorB = new Vector3(0, 0, 0);
  // Start is called before the first frame update
  void Start() {
    Update();
  }

  // Update is called once per frame
  void Update() {
    // If the space key is pressed, show the magnitude, angle, distance and the tallest vector
    if (Input.GetKeyDown(KeyCode.Space)) {
      ShowMagnitude();
      ShowAngle();
      ShowDistance();
      TallestVector();
    }
  }

  // Prints the magnitude of VectorA and VectorB
  void ShowMagnitude() {
    Debug.Log("The magnitude of VectorA is: " + VectorA.magnitude);
    Debug.Log("The magnitude of VectorB is: " + VectorB.magnitude);
  }

  // Prints the angle between VectorA and VectorB
  void ShowAngle() {
    Debug.Log("The angle between VectorA and VectorB is: " + Vector3.Angle(VectorA, VectorB));
  }

  // Prints the distance between VectorA and VectorB
  void ShowDistance() {
    Debug.Log("The distance between VectorA and VectorB is: " + Vector3.Distance(VectorA, VectorB));
  }

  // Prints the tallest vector
  void TallestVector() {
    if (VectorA.y > VectorB.y) {
      Debug.Log("The tallest vector is VectorA");
    } else if (VectorA.y < VectorB.y) {
      Debug.Log("The tallest vector is VectorB");
    } else {
      Debug.Log("Both vectors have the same height");
    }
  }
}
