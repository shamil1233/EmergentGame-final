using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife2 : MonoBehaviour

{

    public static int Health;
    // Use this for initialization
    void Start()
    {
        Health = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Health == 0)
        {
            gameObject.SetActive(false);
            Debug.Log("metoo");
        }
    }
}