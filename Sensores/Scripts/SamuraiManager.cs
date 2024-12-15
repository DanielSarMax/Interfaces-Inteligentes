/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since Diciembre 2024
 * @description Script que controla el movimiento del samurai en el mundo
 */

using UnityEngine;

public class SamuraiManager : MonoBehaviour {
  public float minLatitude = -90f;
  public float maxLatitude = 90f;
  public float minLongitude = -180f;
  public float maxLongitude = 180f;
  public float smoothing = 0.1f;
  public float speedMultiplier = 100f;

  void Start() {
    Input.location.Start();
    Input.compass.enabled = true;
    Input.gyro.enabled = true;
  }

  void Update() {
    CheckLimits();
    SetOrientationToNorth();
    MoveInZAxis();
  }

  private void CheckLimits() {
    if (Input.location.status == LocationServiceStatus.Running) {
      var location = Input.location.lastData;
      if (location.latitude < minLatitude || location.latitude > maxLatitude ||
          location.longitude < minLongitude || location.longitude > maxLongitude) {
          return;
      }
    }
  }

  private void SetOrientationToNorth() {
    float compassHeading = Input.compass.trueHeading;
    Quaternion northRotation = Quaternion.Euler(0, -compassHeading, 0);
    transform.rotation = Quaternion.Slerp(transform.rotation, northRotation, smoothing);
  }

  private void MoveInZAxis() {
    Vector3 acceleration = Input.acceleration;
    Vector3 movement = new Vector3(0, 0, -acceleration.z) * speedMultiplier;
    transform.Translate(movement * Time.deltaTime, Space.World);
  } 

  void OnApplicationQuit() {
    Input.location.Stop();
  }
}