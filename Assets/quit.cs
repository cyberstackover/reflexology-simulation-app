using UnityEngine;
using System.Collections;

public class quit : MonoBehaviour
{
    void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && Mobile())
        {
            Application.Quit();
        }
    }

    private bool Mobile()
    {
        if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsWebPlayer || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.FlashPlayer || Application.platform == RuntimePlatform.OSXDashboardPlayer || Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer || Application.platform == RuntimePlatform.OSXWebPlayer)
            return false;
        else
            return true;
    }
}
