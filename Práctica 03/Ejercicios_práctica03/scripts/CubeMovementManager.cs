/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since October 2024
 * @description Script that manages the movement of the cube.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovementManager : MonoBehaviour {
  public float speed;
  public Vector3 moveDirection;

  // Start is called before the first frame update
  void Start() {
    // Make sure that the cube starts moving at a speed superior to 1
    speed = 2;
    // Initialize the direction of the cube to move in the three axes
    moveDirection = new Vector3(1, 0, 0);
  }

  // Update is called once per frame
  void Update() {
    // Move the cube in the direction of the moveDirection vector. Translate allows us to move the cube in the direction of the vector continuously and not just once.
    transform.Translate(moveDirection.normalized * speed * Time.deltaTime, Space.Self);
  }
}
