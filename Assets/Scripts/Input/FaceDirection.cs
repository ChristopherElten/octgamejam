using UnityEngine;
using System.Collections;

public class FaceDirection : AbstractBehaviour {
	void Update () {
		var right = inputState.GetButtonValue(inputButtons[0]);
		var left = inputState.GetButtonValue(inputButtons[1]);
		var up = inputState.GetButtonValue(inputButtons[2]);
		var down = inputState.GetButtonValue(inputButtons[3]);
		
		if (right){
			inputState.directionX = DirectionsX.Right;
		} else if (left){
			inputState.directionX = DirectionsX.Left;
		} 

		if (up){
			inputState.directionY = DirectionsY.Up;	
		} else if (down){
			inputState.directionY = DirectionsY.Down;
		}
		
//		transform.localScale = new Vector3((float)inputState.direction, 1, 1);
	}
}
