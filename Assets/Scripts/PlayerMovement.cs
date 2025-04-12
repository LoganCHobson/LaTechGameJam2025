using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigi;

    public float speed = 10f;

    public float jumpForce = 5f;

    public Transform groundCheck;

    public LayerMask groundLayer;

    private bool grounded;
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        //float y = Input.GetAxisRaw("Vertical");

        rigi.velocity = new Vector2(x * speed, rigi.velocity.y);


        grounded = Physics2D.Raycast(groundCheck.position, Vector2.down, 0.1f, groundLayer);
        Debug.DrawRay(groundCheck.position, Vector2.down, Color.red);

        
        if (grounded && Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Grounded");
            rigi.velocity = new Vector2(rigi.velocity.x, jumpForce);
        }





    }
}
