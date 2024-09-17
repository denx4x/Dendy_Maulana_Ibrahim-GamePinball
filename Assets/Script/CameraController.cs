using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform target;
    private Vector3 defaultPosition;
    public Transform dummyTarget;

    private void Start() {

        defaultPosition = transform.position;
        target = null;

    }

    private void Update() {

        if (Input.GetKey(KeyCode.Space)) {

            FocusAtTarget(dummyTarget);

        }

        if (Input.GetKey(KeyCode.R)) {

            GoBackToDefault();

        }

    }

    public void FocusAtTarget(Transform targetTransform) {

        target = targetTransform;
        StartCoroutine(MovePosition(targetTransform.position, 5));

    }

    public void GoBackToDefault() {

        target = null;
        StartCoroutine(MovePosition(defaultPosition, 5));

    }

    private IEnumerator MovePosition(Vector3 target, float time) {
        float timer = 0;
        Vector3 start = transform.position;

        while (timer < time) {
            
            transform.position = Vector3.Lerp(start, target, Mathf.SmoothStep(0.0f, 1.0f, timer / time));

            timer += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        transform.position = target;
    }

}
