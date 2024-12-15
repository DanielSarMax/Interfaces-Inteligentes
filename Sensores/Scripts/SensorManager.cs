/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Interfaces Inteligentes
 *
 * @author Daniel David Sarmiento Barrera
 * @since Diciembre 2024
 * @description Script que muestra información de los sensores del dispositivo.
 */

using UnityEngine;
using TMPro;

public class SensorManager : MonoBehaviour {
  public TMP_Text angularVelocityText;
  public TMP_Text accelerationText;
  public TMP_Text altitudeText;
  public TMP_Text gravityText;
  public TMP_Text latitudeText;
  public TMP_Text longitudeText;

  void Start() {
    // Inicia el servicio de localización y habilita la brújula
    Input.location.Start();
    Input.compass.enabled = true;
    Input.gyro.enabled = true;
  }

  void Update() {
    // Actualizar velocidad angular (usando el giroscopio si está disponible)
    if (SystemInfo.supportsGyroscope) {
        Vector3 angularVelocity = Input.gyro.rotationRateUnbiased;
        angularVelocityText.text = $"Velocidad Angular: X={angularVelocity.x:F2}, Y={angularVelocity.y:F2}, Z={angularVelocity.z:F2}";
    } else {
        angularVelocityText.text = "Velocidad Angular: No disponible";
    }

    // Actualizar aceleración
    Vector3 acceleration = Input.acceleration;
    accelerationText.text = $"Aceleración: {acceleration}";

    // Actualizar gravedad (usando el acelerómetro con gravedad)
    Vector3 gravity = Physics.gravity;
    gravityText.text = $"Gravedad: {gravity}";

    if (Input.location.status == LocationServiceStatus.Running) {
        var location = Input.location.lastData;
        latitudeText.text = $"Latitud: {location.latitude}";
        longitudeText.text = $"Longitud: {location.longitude}";
        altitudeText.text = $"Altitud: {location.altitude}";
    } else {
        latitudeText.text = "Latitud: No disponible";
        longitudeText.text = "Longitud: No disponible";
        altitudeText.text = "Altitud: No disponible";
    }
  }

  void OnDisable() {
      // Detener servicios de localización y brújula al salir
      Input.location.Stop();
  }
}
