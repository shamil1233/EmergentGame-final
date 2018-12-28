using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointEffector : MonoBehaviour {

    public GameObject explosion;
    public GameObject particles;
    public static int isTriggered;

    void Start()
    {
        isTriggered = 0;
    }

	//void Update () {
		//if(Input.GetKeyDown(KeyCode.B))
        //if(isTriggered == 1)
		//{
      
          //  StartCoroutine(Destroy());

        //}
	//}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            StartCoroutine(Destroy());
        }
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(2f);
        Instantiate(explosion, transform.position, Quaternion.identity);
        Instantiate(particles, transform.position, Quaternion.identity);
        gameObject.SetActive(false);
    }
}
