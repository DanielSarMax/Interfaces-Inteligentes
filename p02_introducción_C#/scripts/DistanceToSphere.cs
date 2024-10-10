/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since September 2024
 * @description Script that shows the distance between the object and the sphere
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceToSphere : MonoBehaviour {
  private GameObject _sphere;
  // Start is called before the first frame update
  void Start() {
    // Find the sphere object with the tag "Sphere"
    _sphere = GameObject.FindWithTag("Sphere");
    // Calculate the distance between the object and the sphere
    double distance = Vector3.Distance(transform.position, _sphere.transform.position);
    Debug.Log("The distance between " + gameObject.name + " and the sphere is: " + distance);
  }
}
