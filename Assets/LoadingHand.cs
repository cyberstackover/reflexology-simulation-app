using UnityEngine;
using System.Collections;

public class LoadingHand : MonoBehaviour
{
    private float timer = 0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2.0f)
        {
            Application.LoadLevel("hand");
        }
    }
}
