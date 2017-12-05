using UnityEngine;
using System.Collections;

public class tuts : HUDButtonBehaviour
{

    protected override void OnButtonTouchedStationary() { }
    protected override void OnButtonTouchedRelease()
    {
        Application.LoadLevel("tuts");
    }
    protected override void OnButtonTouchedCanceled()
    {

    }

}