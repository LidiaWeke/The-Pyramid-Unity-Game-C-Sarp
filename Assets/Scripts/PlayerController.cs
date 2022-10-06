using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D myRB;
    //es el componente rb para controlar
    public float maxSpeed;

    SpriteRenderer myRenderer;
    bool facingRight = true;

    Animator myAnim;
    //este es el componente de la animación

    bool canMove = true;
    bool grounded = false;
    float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    public Transform groundCheck;
    public float jumpPower;

    private AudioSource sonidoSalto;




    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        myRenderer = GetComponent<SpriteRenderer>();
        myAnim = GetComponent<Animator>();

        sonidoSalto = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    
    {
        if (canMove && grounded && Input.GetAxis("Jump") > 0)
        {
            myAnim.SetBool("isGrounded", false);
            myRB.velocity = new Vector2(myRB.velocity.x, 0f);  //make sure out force is the same each jump
            sonidoSalto.Play();
            myRB.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);  //using a force to make our character jump
            grounded = false;
        }

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer); //draw a circle to check for ground
        myAnim.SetBool("isGrounded", grounded);

        float move = Input.GetAxis("Horizontal");


        if (canMove)
        {
            if (move > 0 && !facingRight)
                Flip();
            else if (move < 0 && facingRight)
                Flip();

            myRB.velocity = new Vector2(move * maxSpeed, myRB.velocity.y);
            myAnim.SetFloat("MoveSpeed", Mathf.Abs(move));
        }
        else
        {  //if we can't move, then don't move
            myRB.velocity = new Vector2(0, myRB.velocity.y);
            myAnim.SetFloat("MoveSpeed", 0);
        }
    }

void Flip ()
    {
        facingRight =! facingRight;
        myRenderer.flipX =! myRenderer.flipX;
      
    }
    /*
    public void ToggleCanMove()
    {
        canMove = !canMove;
    }

    */
}
