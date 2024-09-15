using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {
    // Untuk Input Controller
    public KeyCode input;

    // menyimpan angka target position saat ditekan dan dilepas
    private float targetPressed;
    private float targetReleased;

    // Untuk Menyimpan hinge joint
    private HingeJoint hinge;

    // Start is called before the first frame update
    void Start() {
        hinge = GetComponent<HingeJoint>();

        // saat Start, kita set kedua target tersebut
        targetPressed = hinge.limits.max;
        targetReleased = hinge.limits.min;
    }

    // Update is called once per frame
    void Update() {
        ReadInput();
        MovePaddle();
    }

    void ReadInput() {

        // membuat variabel jointSpring dengan mengambil data Hinge Joint yang telah diambil datanya di Start()
        JointSpring jointSpring = hinge.spring;

        // mengubah target position saat input ditekan dan dilepas
        if (Input.GetKey(input)) {
            jointSpring.targetPosition = targetPressed;
        } else {
            jointSpring.targetPosition = targetReleased;
        }

        // mengubah spring pada Hinge Joint dengan value yang sudah di ubah
        hinge.spring = jointSpring;

    }

    void MovePaddle() {

    }

}














