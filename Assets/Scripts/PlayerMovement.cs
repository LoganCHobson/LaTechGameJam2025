using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigi;

    public float speed = 10f;

    public float jumpForce = 5f;

    public Transform groundCheck;

    public LayerMask groundLayer;

    private Animator anim;

    private bool grounded;
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        Debug.Log(x);
        //float y = Input.GetAxisRaw("Vertical");


         if (rigi.velocity.y !=0)
        {
            anim.Play("Fall");
            if (x > 0)
            {
                if (anim.gameObject.transform.localScale.x < 0)
                {
                    anim.gameObject.transform.localScale = new Vector3(1, 1, 1);
                }
            }
            else if (x < 0)
            {
                if (anim.gameObject.transform.localScale.x > 0)
                {
                    anim.gameObject.transform.localScale = new Vector3(-1, 1, 1);
                }
            }
        }
        else if(x > 0)
        {
            anim.Play("PlayerWalk");
            if (anim.gameObject.transform.localScale.x < 0)
            {
                anim.gameObject.transform.localScale = new Vector3(1, 1, 1);
            }
        }

        else if(x < 0) 
        {
            anim.Play("PlayerWalk");
            if (anim.gameObject.transform.localScale.x > 0)
            {
                anim.gameObject.transform.localScale = new Vector3(-1, 1, 1);
            }
        }
        
        else
        {
            anim.Play("Idle");
        }
        

        rigi.velocity = new Vector2(x * speed, rigi.velocity.y);


        grounded = Physics2D.Raycast(groundCheck.position, Vector2.down, 0.1f, groundLayer);
        Debug.DrawRay(groundCheck.position, Vector2.down, Color.red);

        
        if (grounded && Input.GetKey(KeyCode.Space))
        {
            anim.Play("Jump");
            
            Debug.Log("Grounded");
            rigi.velocity = new Vector2(rigi.velocity.x, jumpForce);
        }

    }
}
