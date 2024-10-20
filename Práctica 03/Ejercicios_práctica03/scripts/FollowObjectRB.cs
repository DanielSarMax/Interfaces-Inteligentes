/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since October 2024
 * @description Script that makes an RigidObject follow another object.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObjectRB : MonoBehaviour {
  public GameObject objectToFollow;
  public float speed;
  public float rotationSpeed;
  private Rigidbody _rigidbody;

  // Start is called before the first frame update
  void Start() {
    speed = 50;
    rotationSpeed = 2;
    _rigidbody = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update() {
    if (Input.GetKey(KeyCode.F)) {
      Vector3 direction = (objectToFollow.transform.position - transform.position).normalized;
      _rigidbody.AddForce(direction * speed * Time.deltaTime, ForceMode.Force);
      _rigidbody.rotation = Quaternion.Slerp(_rigidbody.rotation, Quaternion.LookRotation(direction), rotationSpeed * Time.deltaTime);
    }
  }
}