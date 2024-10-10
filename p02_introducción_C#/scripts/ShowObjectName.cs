/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since September 2024
 * @description Script that shows the name of the object in the console
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowObjectName : MonoBehaviour
{
  // Start is called before the first frame update
  void Start() {
    Debug.Log("The object name is: " + gameObject.name);
  }
}
