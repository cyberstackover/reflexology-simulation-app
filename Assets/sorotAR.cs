using UnityEngine;
using System.Collections;

public class sorotAR : HUDButtonBehaviour
{

    protected override void OnButtonTouchedStationary() { }
    protected override void OnButtonTouchedRelease()
    {
        Application.LoadLevel("loading");
    }
    protected override void OnButtonTouchedCanceled()
    {

    }

}