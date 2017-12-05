using UnityEngine;
using System.Collections;

public class HUDBehaviour : MonoBehaviour {
    public FABehaviour faBehaviour;
    void Start() {
        HUDButtonBehaviour[] hudButtonBehaviour = GetComponentsInChildren<HUDButtonBehaviour>();
        for (int i = 0; i < hudButtonBehaviour.Length; i++)
        {
            hudButtonBehaviour[i].SetFaBehaviour(faBehaviour);
        }
    }
}
