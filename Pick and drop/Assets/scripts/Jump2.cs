using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump2: MonoBehaviour {

public float jumpForce = 600f;
public LayerMask theGround;
public Transform groundCheck;
bool onTheGround = false;
public float velY;

public bool jump = false;
public Animator animator;

    Rigidbody2D rigBody;

void Start()
{
	rigBody = GetComponent<Rigidbody2D>();
}
void Update()
{
	onTheGround = Physics2D.Linecast(transform.position, groundCheck.position, theGround);
	if(onTheGround && Input.GetButtonDown ("Jump2"))
	{
		velY = 0f;
		rigBody.AddForce(new Vector2(0, jumpForce));
	}
        if (onTheGround)
        {
            jump = false;
            animator.SetBool("IsJumping", false);
        }
        else
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }
    }
}
