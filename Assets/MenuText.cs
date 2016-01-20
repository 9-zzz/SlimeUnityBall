using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuText : MonoBehaviour {

    public int indexToLoad;
	// Use this for initialization
	void Start () {
	
	}

    public void LoaderThing()
    {
        SceneManager.LoadScene(indexToLoad);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
