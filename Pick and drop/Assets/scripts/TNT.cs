using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNT : MonoBehaviour
{

    public GameObject Explosion;
    public bool Triggered = false;
    public bool DestroyableObject1Detected = false;
    public bool DestroyableObject2Detected = false;
    public Transform player1;
    public Transform player2;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player") || col.gameObject.tag.Equals("Player2"))
        {
            Triggered = true;
            StartCoroutine (Destroy());
            //start destroy anim
        }
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            DestroyableObject1Detected = true;
            
        }
        else if (col.gameObject.tag.Equals("Player2"))
        {
            DestroyableObject2Detected = true;

        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player1"))
        {
            DestroyableObject1Detected = false;

        }
        else if(col.gameObject.tag.Equals("Player2"))
        {
            DestroyableObject2Detected = false;

        }
    }



    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(2f);
       if(Triggered == true)
        {
            gameObject.SetActive(false);
            Instantiate(Explosion, transform.position, Quaternion.identity);
            //Sound
        }

        else if (Triggered == true && DestroyableObject1Detected == true)
        {
            gameObject.SetActive(false);
            PlayerLife1.Health -= 1;
        }

        else if (Triggered == true && DestroyableObject2Detected == true)
        {
            gameObject.SetActive(false);
            PlayerLife2.Health -= 1;     
        }

        else if (Triggered == true && DestroyableObject2Detected == true && DestroyableObject1Detected == true)
        {
            gameObject.SetActive(false);
            PlayerLife2.Health -= 1;
            PlayerLife1.Health -= 1;
        }
    }
}
