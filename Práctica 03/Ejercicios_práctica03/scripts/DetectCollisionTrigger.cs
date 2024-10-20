/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since October 2024
 * @description Script that makes an object detect collisions with other objects.
 *              Also, it print the tag of the object it collided with.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionTrigger : MonoBehaviour {
  void OnTriggerEnter(Collider other) {
    Debug.Log(gameObject.tag + " collided with: " + other.gameObject.tag);
  }
}
