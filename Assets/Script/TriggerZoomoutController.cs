using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomoutController : MonoBehaviour {

    public Collider bola;
    public CameraController cameraController;

    private void OnTriggerEnter(Collider other) {

        if (other == bola) {

            cameraController.GoBackToDefault();

        }

    }

}
