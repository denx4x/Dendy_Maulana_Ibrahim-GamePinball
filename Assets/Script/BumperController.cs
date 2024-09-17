using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour {
    
    public Collider bola;
    public float multiplier;
    public Color color;

    private Renderer renderer;
    private Animator animator;

    public AudioManager audioManager;
    public VFXManager VFXManager;

    public ScoreManager scoreManager;
    public float score;

    void Start () {
        
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();

        renderer.material.color = color;

    }

    void OnCollisionEnter(Collision collision) {
        
        if(collision.collider == bola) {
           
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            animator.SetTrigger("hit");

            audioManager.PlaySFX(collision.transform.position);
            VFXManager.PlayVFX(collision.transform.position);

            scoreManager.AddScore(score);

        }

    }

}
