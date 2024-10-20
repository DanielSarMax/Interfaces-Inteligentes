/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since October 2024
 * @description Script that makes an object continuously advance in the direction it is facing.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAndAdvance : MonoBehaviour {
  public float speed;
  public float rotationSpeed;
  private float _horizontalInput;

  // Start is called before the first frame update
  void Start() {
    speed = 2;
    rotationSpeed = 100;
  }

  // Update is called once per frame
  void Update() {
    _horizontalInput = Input.GetAxis("Horizontal");
    transform.Rotate(Vector3.up * _horizontalInput * rotationSpeed * Time.deltaTime, Space.Self);
    transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
  }
}