using UnityEngine;
using System.Collections;

public class CollisionState : MonoBehaviour {

	public LayerMask collisionLayer;
	public bool againstWallX;
	public bool againstWallY;
	public bool isWalking;
	public Vector2 topPosition = Vector2.zero;
	public Vector2 bottomPosition = Vector2.zero;
	public Vector2 rightPosition = Vector2.zero;
	public Vector2 leftPosition = Vector2.zero;
	public float collisionRadius = 10f;
	public Color debugCollisionColor = Color.red;

	private InputState inputState;

	void Awake(){
		inputState = GetComponent<InputState>();
	}

	void FixedUpdate(){
		//Only checking for collisions with environment collision layer when the player is facing/moving in respective direction...
		Vector2 pos;
		switch (inputState.directionX){
			case (DirectionsX.Right):
				pos = rightPosition;
				break;
			case (DirectionsX.Left):
				pos = leftPosition;
				break;
			default:
				pos = rightPosition;
				break;
		}

		pos.x += transform.position.x;
		pos.y += transform.position.y;
		
		againstWallX = Physics2D.OverlapCircle(pos, collisionRadius, collisionLayer);

		switch (inputState.directionY){
		case (DirectionsY.Up):
			pos = topPosition;
			break;
		case (DirectionsY.Down):
			pos = bottomPosition;
			break;
		default:
			pos = topPosition;
			break;
		}
	pos.x += transform.position.x;
		pos.y += transform.position.y;
		
		againstWallY = Physics2D.OverlapCircle(pos, collisionRadius, collisionLayer);
	}

	void OnDrawGizmos(){
		Gizmos.color = debugCollisionColor;

		var positions = new Vector2[] {rightPosition, bottomPosition, leftPosition};

		foreach(var position in positions){
			var pos = position;
			pos.x += transform.position.x;
			pos.y += transform.position.y;
			Gizmos.DrawWireSphere(pos, collisionRadius);
		}
	}
}
