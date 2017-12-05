using UnityEngine;
using System.Collections;

public abstract class HUDButtonBehaviour : TouchButtonBehaviour {
    protected FABehaviour faBehaviour;
    public void SetFaBehaviour(FABehaviour faBehaviour){
        this.faBehaviour = faBehaviour;
    }
}
