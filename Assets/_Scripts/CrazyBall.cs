using UnityEngine;
using System.Collections;

public class CrazyBall : MonoBehaviour
{
    Vector3 startingPosOne;
    Vector3 startingPosTwo;
    Rigidbody2D rb2D;
    public float maxSpeed;

    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start()
    {
        startingPosOne = PlayerOneSlime.S.transform.position;
        startingPosTwo = PlayerTwoSlime.S.transform.position;
    }

    void FixedUpdate()
    {
        if (rb2D.velocity.magnitude > maxSpeed)
        {
            rb2D.velocity = rb2D.velocity.normalized * maxSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(rb2D.velocity.magnitude);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        maxSpeed += 0.1f;

        if (col.gameObject.tag == "floor" && (transform.position.x < 0))
        {
            ScoreKeeper.S.blueScore++;
            ScoreKeeper.S.IncrementVisualScoreBlue();

            PlayerOneSlime.S.transform.position = startingPosOne;
            transform.position = PlayerOneSlime.S.transform.position + Vector3.up * 3.56f;

            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }

        if (col.gameObject.tag == "floor" && (transform.position.x > 0))
        {
            ScoreKeeper.S.redScore++;
            ScoreKeeper.S.IncrementVisualScoreRed();

            PlayerTwoSlime.S.transform.position = startingPosTwo;
            transform.position = PlayerTwoSlime.S.transform.position + Vector3.up * 3.56f;

            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
    }

}
