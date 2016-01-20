using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    Vector3 startingPosOne;
    Vector3 startingPosTwo;

    // Use this for initialization
    void Start()
    {
        startingPosOne = PlayerOneSlime.S.transform.position;
        startingPosTwo = PlayerTwoSlime.S.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
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
