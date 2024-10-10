/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since September 2024
 * @description Script that shows the position of the object in a text object
 */

using UnityEngine;
using TMPro;

public class ShowPositionInText : MonoBehaviour {
  private TMP_Text _positionText; // Variable to store the text object 
  void Start() {
    _positionText = GameObject.FindWithTag("PositionText").GetComponent<TMP_Text>();
  }


  void Update() {
    Vector3 spherePosition = transform.position;
    _positionText.text = "Posición de la esfera: " + spherePosition.ToString("F2");
  }
}

