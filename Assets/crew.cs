using UnityEngine;
using System.Collections;

public class crew : HUDButtonBehaviour
{ 

    protected override void OnButtonTouchedStationary() { }
    protected override void OnButtonTouchedRelease()
    {
        Application.LoadLevel("crew");
    }
    protected override void OnButtonTouchedCanceled()
    {

    }

}
