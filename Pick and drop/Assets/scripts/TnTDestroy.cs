using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TnTDestroy : MonoBehaviour {

public GameObject explosion;
void OnTriggerEnter2D (Collider2D collision)
  {
		if (collision.gameObject.tag == "draggable")
		{
        Instantiate(explosion, transform.position, Quaternion.identity);
		Destroy (gameObject);
        gameObject.SetActive(false);
		}

  }
   
}
