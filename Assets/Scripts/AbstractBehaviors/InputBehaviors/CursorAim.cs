using UnityEngine;
using System.Collections;

public class CursorAim : Aim {

	protected InputState inputState;
	
	void Awake(){
		inputState = GetComponent<InputState>();
	}

	protected override void Update(){
		itemBeingAimed.rotation = Quaternion.Euler(0f, 0f, GetRotZ(inputState.cursorPos) - 90);
	}

}
