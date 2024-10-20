/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since October 2024
 * @description Script that makes an object follow another object.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour {
  public GameObject objectToFollow;
  public float speed;

  // Start is called before the first frame update
  void Start() {
    speed = 2;
  }

  // Update is called once per frame
  void Update() {
    Vector3 direction = (objectToFollow.transform.position - transform.position).normalized;
    direction.y = 0;
    transform.Translate(direction * speed * Time.deltaTime);
  }
}
