using UnityEngine;
using System.Collections;

public class PlayerOneSlime : MonoBehaviour
{
    public static PlayerOneSlime S;

    public float Speed = 0f;
    public float JumpForce;
    public bool CanJump;
    Rigidbody2D rb2D;

    void Awake()
    {
        S = this;
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 inp = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        rb2D.MovePosition(transform.position + (inp * 10.0f * Time.deltaTime));
    }

    void OnCollisionStay2D(Collision2D col)
    {

    }

}
