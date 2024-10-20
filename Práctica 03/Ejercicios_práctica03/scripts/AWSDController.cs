/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since October 2024
 * @description Script that manages the movement of an object using the AWSD keys.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowControl : MonoBehaviour {
  public float speed;
  // Start is called before the first frame update
  void Start() {
    speed = 2;
  }

  // Update is called once per frame
  void Update() {
    if (Input.GetKey(KeyCode.W)) {
      transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
    else if (Input.GetKey(KeyCode.S)) {
      transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
    else if (Input.GetKey(KeyCode.A)) {
      transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    else if (Input.GetKey(KeyCode.D)) {
      transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
  }
}
