/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since October 2024
 * @description Script that prints the speed of the cube when the arrow keys are pressed.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpeed : MonoBehaviour {
	public double Speed;
	private double _horizontalMovement;
	private double _verticalMovement;

	void Start() {
		Speed = 1;
	}

	void Update() {
		// Returns a value between -1 and 1. Left is -1, Right is 1.
		_horizontalMovement = Input.GetAxis("Horizontal");
		// Returns a value between -1 and 1. Down is -1, Up is 1.
		_verticalMovement = Input.GetAxis("Vertical");
		if (Input.GetKey(KeyCode.UpArrow)) {
			Debug.Log("UpArrow-Speed: " + (Speed * _verticalMovement));
		}
		else if (Input.GetKey(KeyCode.DownArrow)) {
			Debug.Log("DownArrow-Speed: " + (Speed * _verticalMovement));
		}
		else if (Input.GetKey(KeyCode.LeftArrow)) {
			Debug.Log("LeftArrow-Speed: " + (Speed * _horizontalMovement));
		}
		else if (Input.GetKey(KeyCode.RightArrow)) {
			Debug.Log("RightArrow-Speed: " + (Speed * _horizontalMovement));
		}
	}
}
