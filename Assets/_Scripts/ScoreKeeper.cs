using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ScoreKeeper : MonoBehaviour
{

    public static ScoreKeeper S;

    public GameObject bsb;
    public GameObject rsb;
    public int redScore = -1;
    public int blueScore = -1;

    void Awake()
    {
        S = this;
    }

    public void IncrementVisualScoreRed()
    {
        if (redScore == 4)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        rsb.transform.GetChild(redScore).GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
    }

    public void IncrementVisualScoreBlue()
    {
        if (blueScore == 4)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        bsb.transform.GetChild(blueScore).GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
