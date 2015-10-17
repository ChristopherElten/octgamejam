using UnityEngine;
using System.Collections;

public class CursorIcon : AbstractBehaviour {

	[SerializeField] Transform cursorIcon;

	protected InputState inputState;
	
	protected override void Awake(){
		base.Awake();
		inputState = GetComponent<InputState>();
	}

	void Update () {

		var cursorX = inputState.cursorPos.x;
		var cursorY = inputState.cursorPos.y;
		
		cursorIcon.position = new Vector2(cursorX, cursorY);

	}
}
