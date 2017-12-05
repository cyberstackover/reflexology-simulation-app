using UnityEngine;
using System.Collections;

public class SkiptoMenu : HUDButtonBehaviour
{

    protected override void OnButtonTouchedStationary() { }
    protected override void OnButtonTouchedRelease()
    {
        Application.LoadLevel("menu");
    }
    protected override void OnButtonTouchedCanceled()
    {

    }

}