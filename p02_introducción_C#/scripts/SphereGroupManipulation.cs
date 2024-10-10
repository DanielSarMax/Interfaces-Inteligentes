/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since September 2024
 * @description Script that increments the heigth of the type 2 sphere that is closer to the cube. 
                It also changes the color of the type 1 sphere that is further from the cube.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGroupManipulation : MonoBehaviour {
  private GameObject _cube;
  private GameObject[] _type1Spheres;
  private GameObject[] _type2Spheres;

  // Start is called before the first frame update
  void Start() {
    _cube = GameObject.FindWithTag("Cube");
    _type1Spheres = GameObject.FindGameObjectsWithTag("EsferaTipo1");
    _type2Spheres = GameObject.FindGameObjectsWithTag("EsferaTipo2");
  }

  // Update is called once per frame
  void Update() {
    if (Input.GetKeyDown(KeyCode.Space)) {
      IncrementHeight();
      ChangeColor();
    }
  }

  // Increments the height of the type 2 sphere that is closer to the cube
  void IncrementHeight() {
    GameObject closestSphere = _type2Spheres[0];
    float minDistance = Vector3.Distance(_cube.transform.position, closestSphere.transform.position);

    foreach (GameObject sphere in _type2Spheres) {
      float distance = Vector3.Distance(_cube.transform.position, sphere.transform.position);
      if (distance < minDistance) {
        minDistance = distance;
        closestSphere = sphere;
      }
    }

    closestSphere.transform.position += new Vector3(0, 1, 0);
  }

  // Changes the color of the type 1 sphere that is further from the cube
  void ChangeColor() {
    GameObject furthestSphere = _type1Spheres[0];
    float maxDistance = Vector3.Distance(_cube.transform.position, furthestSphere.transform.position);

    foreach (GameObject sphere in _type1Spheres) {
      float distance = Vector3.Distance(_cube.transform.position, sphere.transform.position);
      if (distance > maxDistance) {
        maxDistance = distance;
        furthestSphere = sphere;
      }
    }

    furthestSphere.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
  }
}
