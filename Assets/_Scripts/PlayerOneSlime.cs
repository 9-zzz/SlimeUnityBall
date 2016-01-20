using UnityEngine;
using System.Collections;

public class PlayerOneSlime : MonoBehaviour
{
    public static PlayerOneSlime S;

    public float forceSpeed;
    public float topSpeed;
    public Vector2 Speed;
    public Vector2 JumpForce;
    public bool isGrounded;
    Rigidbody2D rb2D;

    void Awake()
    {
        S = this;
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (transform.position.y <= -3.5f)
            isGrounded = true;

        if (isGrounded && Input.GetKeyDown(KeyCode.W))
        {
            rb2D.AddForce(new Vector2(0, forceSpeed), ForceMode2D.Impulse);
            isGrounded = false;
        }

        float h = Input.GetAxis("Horizontal");
        rb2D.AddForce((Vector2.right * 500.0f) * h);

        if (rb2D.velocity.x > 0.0f || rb2D.velocity.x < 0.0f)
            rb2D.velocity = Vector2.MoveTowards(rb2D.velocity, new Vector2(0, rb2D.velocity.y), 100.0f);
    }

    //void Update() { //Vector3 inp = new Vector2(Input.GetAxis("Horizontal"), 0); //rb2D.MovePosition(transform.position + (inp * 10.0f * Time.deltaTime)); }

}
