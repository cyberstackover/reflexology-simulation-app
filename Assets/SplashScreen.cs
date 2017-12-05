using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {
    public float timer = 5f;
    public string levelToLoad = "start";

	// Use this for initialization
	void Start () {
        StartCoroutine("DisplayScene");
	}

    IEnumerator DisplayScene() {
        yield return new WaitForSeconds(timer);
        Application.LoadLevel(levelToLoad);
    }
}
