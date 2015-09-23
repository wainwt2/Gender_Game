using UnityEngine;
using System.Collections;

public class Creature_Animation : MonoBehaviour {

	private Click_and_Drag _CD;
	private Animator anim;
	int DragHash = Animator.StringToHash("Drag");
	int RunHash = Animator.StringToHash("Run");
	int HappyHash = Animator.StringToHash("Happy");
	bool DragPara = true;
	bool RunPara = false;
	bool HappyPara = false;

	// Use this for initialization
	void Start () {
		_CD = GetComponent<Click_and_Drag> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		RunPara = false;

		// check if being drag
		DragPara = _CD.dragging;

		// if not being drag
		if (!DragPara) {
			// check if not happy 
			if(!HappyPara){
				RunPara = true;	
			}
		}

		// update animation
		anim.SetBool ("Drag", DragPara);
		anim.SetBool ("Run", RunPara);
		anim.SetBool ("Happy", HappyPara);
	}

	public void IsHappy(bool happy){
		HappyPara = happy;
	}
}
