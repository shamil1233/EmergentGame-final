using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag2 : MonoBehaviour
{

    public float distance = 1f;
    public LayerMask boxMask;

    public LayerMask theGround;
    public Transform groundCheck;
    bool onTheGround = false;

    GameObject box;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        onTheGround = Physics2D.Linecast(transform.position, groundCheck.position, theGround);
        Physics2D.queriesStartInColliders = false;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, distance, boxMask);
        if (hit.collider != null && hit.collider.gameObject.tag == "draggable" && Input.GetKeyDown(KeyCode.P) && onTheGround)
        {
            box = hit.collider.gameObject;
            box.GetComponent<FixedJoint2D>().enabled = true;
            box.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D>();
        }
        else if (Input.GetKeyUp(KeyCode.P))
        {
            box.GetComponent<FixedJoint2D>().enabled = false;
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, (Vector2)transform.position + Vector2.right * transform.localScale.x * distance);
    }
}
