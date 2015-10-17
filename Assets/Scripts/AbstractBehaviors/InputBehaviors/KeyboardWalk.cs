using UnityEngine;
using System.Collections;

public class KeyboardWalk : Walk {

	protected InputState inputState;
	public Buttons[] inputButtons;

	protected override void Awake(){
		base.Awake();
		inputState = GetComponent<InputState>();
	}
	
	void Update () {
		var right = inputState.GetButtonValue(inputButtons[0]);
		var left = inputState.GetButtonValue(inputButtons[1]);
		var up = inputState.GetButtonValue(inputButtons[2]);
		var down = inputState.GetButtonValue(inputButtons[3]);


		if (right || left){
			var tmpSpeedX = speedX;
			var velX = tmpSpeedX*(float)inputState.directionX;
			MoveHorizontal(velX);
		} 
		
		if (up || down){
			var tmpSpeedY = speedY;
			var velY = tmpSpeedY*(float)inputState.directionY;
			MoveVertical(velY);
		}
		
		if(!right && !left && !up && !down){
			StopMovement();
		}
	}
}
