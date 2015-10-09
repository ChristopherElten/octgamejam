using UnityEngine;
using System.Collections;

public class KeyboardFaceDirection : FaceDirection {

	protected InputState inputState;
	public Buttons[] inputButtons;

	protected  void Awake(){
		inputState = GetComponent<InputState>();
	}

	protected  void Update () {
		right = inputState.GetButtonValue(inputButtons[0]);
		left = inputState.GetButtonValue(inputButtons[1]);
		up = inputState.GetButtonValue(inputButtons[2]);
		down = inputState.GetButtonValue(inputButtons[3]);

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
	}
}
