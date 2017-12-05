using UnityEngine;
using System.Collections;

[RequireComponent(typeof(GUITexture))]
public abstract class TouchButtonBehaviour : MonoBehaviour {
	public Texture buttonIcon, buttonIconTouched;
    public AudioClip buttonSound;
	private int touchId=-1;
	
	void Start () {
        this.gameObject.AddComponent<AudioSource>();
        this.audio.volume = 0.25f;

		this.guiTexture.texture=buttonIcon;

        OnButtonStart();
	}
	
	Touch [] fingerTouches;
	void Update(){
		fingerTouches=Input.touches;
		if(fingerTouches.Length > 0){
			for(int i=0; i<fingerTouches.Length; i++){
				if(this.guiTexture.HitTest(fingerTouches[i].position)){
					if(fingerTouches[i].phase!=TouchPhase.Ended){
						touchId=fingerTouches[i].fingerId;
						this.guiTexture.texture=buttonIconTouched;
						OnButtonTouchedStationary();
					}else{
						if(fingerTouches[i].fingerId==touchId){
							touchId=-1;
							this.guiTexture.texture=buttonIcon;
							OnButtonTouchedRelease();
						}
					}
				}else{
					if(fingerTouches[i].fingerId==touchId){
						touchId=-1;
						this.guiTexture.texture=buttonIcon;
						OnButtonTouchedCanceled();
					}	
				}
			}
			
		}

        //for testing purpose
        if (isClickedStationary) {
            OnButtonTouchedStationary();
        }
		
		OnButtonUpdate();
	}


    // for testing purpose
    private bool isClickedStationary = false;
    void OnMouseDown() {
        if (isClickedStationary == false && buttonSound!=null){
            audio.PlayOneShot(buttonSound);
		}
        this.guiTexture.texture = buttonIconTouched;
        isClickedStationary = true;
    }

    void OnMouseUp() {
        this.guiTexture.texture = buttonIcon;
        isClickedStationary = false;
        if (this.guiTexture.HitTest(Input.mousePosition)) {
            OnButtonTouchedRelease();
        }
    }

    protected virtual void OnButtonStart() { }
	protected virtual void OnButtonUpdate(){}
	protected abstract void OnButtonTouchedStationary();
	protected abstract void OnButtonTouchedRelease();
	protected abstract void OnButtonTouchedCanceled();
}
