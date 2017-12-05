using UnityEngine;
using System.Collections;

public class hand : HUDButtonBehaviour
{

    protected override void OnButtonTouchedStationary() { }
    protected override void OnButtonTouchedRelease()
    {
        Application.LoadLevel("loadinghand");
    }
    protected override void OnButtonTouchedCanceled()
    {

    }

}