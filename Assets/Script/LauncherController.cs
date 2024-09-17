using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour {
    public Collider bola;
    public KeyCode input;

    public float maxTimeHold;
    public float maxForce;

    private Renderer renderer;
    private bool isHold;

    [SerializeField] private Material onMat;
    [SerializeField] private Material offMat;

    void Start() {
       
        isHold = false;

        renderer = GetComponent<Renderer>();

    }

    void OnCollisionStay(Collision collision) {
       
        if (collision.collider == bola) {
            ReadInput(bola);
        }

    }

    void ReadInput(Collider collider) {
        
        if (Input.GetKey(input) && !isHold) {
            StartCoroutine(StartHold(collider));
        }

    }

    IEnumerator StartHold(Collider collider) {

        renderer.material = onMat;

        isHold = true;

        float force = 0.0f;
        float timeHold = 0.0f;

        while (Input.GetKey(input)) {
           
            force = Mathf.Lerp(0, maxForce, timeHold / maxTimeHold);

            yield return new WaitForEndOfFrame();
            timeHold += Time.deltaTime;

        }

        collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        isHold = false;
        renderer.material = offMat;

    }

}
