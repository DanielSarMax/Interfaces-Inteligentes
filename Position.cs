/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since September 2024
 * @description Script que muestra la posición de los objetos activos en la escena
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase que muestra la posición de los objetos activos en la escena
public class PrintObjectPositions : MonoBehaviour {
  // Start is called before the first frame update
  void Start() {
    // Buscar todos los objetos en la escena usando FindObjectsOfType
    GameObject[] allObjects = FindObjectsOfType<GameObject>();
    // Iteramos sobre todos los objetos encontrados
    foreach (GameObject obj in allObjects) {
      // Filtramos los objetos, de tal forma que solo mostramos la posición de los objetos activos
      if (obj.activeInHierarchy) {
        // Obtenemos la posición del objeto y la almacenamos
        Vector3 position = obj.transform.position;
        // Mostramos el nombre del objeto y su posición en la consola
        Debug.Log(obj.name + " está en la posición: " + position);
      }
    }
  }
}

