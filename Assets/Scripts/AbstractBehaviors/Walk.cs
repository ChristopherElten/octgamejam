using UnityEngine;
using System.Collections;

public class Walk : AbstractBehaviour {

	public float speedX;
	public float speedY;

	protected void MoveHorizontal(float velX){
		collisionState.isWalking = true;
		body2D.velocity = new Vector2(velX, body2D.velocity.y);
	}
	protected void MoveVertical(float velY){
		collisionState.isWalking = true;
		body2D.velocity = new Vector2(body2D.velocity.x, velY);
	}
	protected void StopMovement(){
		collisionState.isWalking = false;
		body2D.velocity = new Vector2(0, 0);
	}
}
