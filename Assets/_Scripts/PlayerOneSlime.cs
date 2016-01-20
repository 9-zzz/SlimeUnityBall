using UnityEngine;
using System.Collections;

public class PlayerOneSlime : MonoBehaviour
{
    public static PlayerOneSlime S;

    public float Speed = 0f;
    public float JumpForce;
    private float move = 0f;
    public bool CanJump;
    Rigidbody2D rb2D;

    void Awake()
    {
        S = this;
    }

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Vector3 inp = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        GetComponent<Rigidbody2D>().MovePosition(transform.position + (inp * 10.0f * Time.deltaTime));

    if (Input.GetKey(KeyCode.W) && CanJump)
        {
        rb2D.AddForce(new Vector2(rb2D.velocity.x, JumpForce), ForceMode2D.Impulse);
        CanJump = false;
        }
    }

    /*
void FixedUpdate()
{
    move = Input.GetAxis("Horizontal");
    rb2D.velocity = new Vector2(move * Speed, rb2D.velocity.y);

    if (Input.GetKey(KeyCode.W) && CanJump)
    {
        rb2D.AddForce(new Vector2(rb2D.velocity.x, JumpForce), ForceMode2D.Impulse);
        CanJump = false;
    }
}


void OnCollisionEnter2D(Collision2D col)
{
    if (col.gameObject.tag == "bound")
        rb2D.velocity = new Vector2(move * Speed, 0.0f);
}

    */
void OnCollisionStay2D(Collision2D col)
{
    if (col.gameObject.tag == "floor")
    {
        CanJump = true;
    }
}

}
