using UnityEngine;
using System.Collections;

public class Back : MonoBehaviour {
	void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && Mobile())
        {
			Application.LoadLevel("menu");
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
