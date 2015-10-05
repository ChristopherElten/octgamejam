using UnityEngine;
using System.Collections;

public class Walk : AbstractBehaviour {

	public float speedX = 50f;
	public float speedY = 50f;

	void Update () {
		var right = inputState.GetButtonValue(inputButtons[0]);
		var left = inputState.GetButtonValue(inputButtons[1]);
		var up = inputState.GetButtonValue(inputButtons[2]);
		var down = inputState.GetButtonValue(inputButtons[3]);


		if (right || left){
			var tmpSpeedX = speedX;
			var velX = tmpSpeedX*(float)inputState.directionX;
			body2D.velocity = new Vector2(velX, body2D.velocity.y);
		} 

		if (up || down){
			var tmpSpeedY = speedY;
			var velY = tmpSpeedY*(float)inputState.directionY;
			body2D.velocity = new Vector2(body2D.velocity.x, velY);
		} 

		if(!right && !left && !up && !down){
			collisionState.isWalking = false;
			body2D.velocity = new Vector2(0, 0);
			collisionState.isWalking = false;
		} else {
			collisionState.isWalking = true;
		}
	}
}
