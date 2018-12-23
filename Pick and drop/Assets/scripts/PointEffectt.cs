using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointEffectt : MonoBehaviour {

	public GameObject explosion;
    public GameObject wall;

void Start()
{
      //wall = GameObject.FindGameObjectWithTag("BreakWall");
}
	
void Update()
{  
  if(Input.GetKeyDown(KeyCode.B))
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        //gameObject.SetActive(false);
        Destroy(gameObject);
        
       
    }

}




 
    /* 
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "BreakWall" && Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
            Destroy(gameObject, 2f);

        
        }
    }
    */
}


