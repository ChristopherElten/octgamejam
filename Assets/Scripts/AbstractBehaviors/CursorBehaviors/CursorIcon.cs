using UnityEngine;
using System.Collections;

public class CursorIcon : AbstractBehaviour {

	[SerializeField] Transform cursorIcon;

	void Update () {

		var cursorX = inputState.cursorPos.x;
		var cursorY = inputState.cursorPos.y;
		
		cursorIcon.position = new Vector2(cursorX, cursorY);

	}
}
