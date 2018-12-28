using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TntAnimation : MonoBehaviour {

    public static int isTriggered;
    public Animator animator;

    // Use this for initialization
    void Start () {
        isTriggered = 0;
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            animator.SetBool("Triggered", true);
        }
    }
}
