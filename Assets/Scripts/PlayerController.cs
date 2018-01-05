using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float jumpForce = 25f;
    public float runningSpeed = 1.5f;
    public LayerMask groundLayer;
    private Rigidbody2D rigidBody;
    public Animator animator;

    
    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
	// Use this for initialization
	void Start () {
        animator.SetBool("isAlive", true);
	}
	
	// Update is called once per frame
	void Update () {
        // this is exaclty same as if(Input.GetMouseButtonDown(0)	==	true)
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
        }
        animator.SetBool("isGrounded", IsGrounded());
	}


    void Jump()
    {
        if (IsGrounded())
        {
            rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    

    bool IsGrounded()
    {
        if (Physics2D.Raycast(this.transform.position, Vector2.down, 0.2f, groundLayer.value))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
