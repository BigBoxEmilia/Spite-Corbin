using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class playerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float walkSpeed = 5f;
    private float xAxis;
    public float jumpForce = 10f;

    Animator anim;

    public bool grounded = true;


    void Start()
    {
       rb = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();
    }

    void getInputs()
    {
        xAxis = Input.GetAxisRaw("Horizontal");

    }
    void Flip()
    {
        if(xAxis < 0)
        {
            transform.localScale = new Vector2(-0.5447f, transform.localScale.y);
        }
        else if(xAxis > 0){
            transform.localScale = new Vector2(0.5447f, transform.localScale.y);
        }
    }


    private void Move()
    {
        rb.velocity = new Vector2(walkSpeed* xAxis, rb.velocity.y);
        anim.SetBool("Standing", rb.velocity.x == 0 && grounded);

    }
    private void Jump()
    {
        if(Input.GetButtonDown("Jump") && grounded ==true)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpForce));
        }
    }

   

    void Update()
    {
        getInputs();
        Move();
        Jump();
        Flip();
    }



    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            grounded = true;
        }
         
        
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor")){
            grounded = false;
        }
    }
}
