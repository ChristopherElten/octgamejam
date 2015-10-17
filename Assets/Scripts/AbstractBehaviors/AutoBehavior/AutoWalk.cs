using UnityEngine;
using System.Collections;

public class AutoWalk : Walk {

	bool isMoving;
	[SerializeField] float moveSpeed;

	IEnumerator WalkTowardsTransform(Transform target){
		while(!Mathf.Approximately(transform.position.x, target.position.x) || !Mathf.Approximately(transform.position.y, target.position.x)){
			transform.position = Vector3.MoveTowards (transform.position, target.position, moveSpeed);
			yield return null;
		}
	}

	IEnumerator Walk(float t){
		if (isMoving) yield break;
		isMoving = true;
		for (int i = 0; i < t; i++){
			MoveHorizontal(-speedX);
			yield return null;
		}
		isMoving = false;
	}

	IEnumerator WalkRight(float t){
		if (isMoving) yield break;
		isMoving = true;
		for (int i = 0; i < t; i++){
			MoveHorizontal(speedX);
			yield return null;
		}
		isMoving = false;
	}

	IEnumerator WalkUp(float t){
		if (isMoving) yield break;
		isMoving = true;
		for (int i = 0; i < t; i++){
			MoveVertical(speedY);
			yield return null;
		}
		isMoving = false;
	}

	IEnumerator WalkDown(float t){
		if (isMoving) yield break;
		isMoving = true;
		for (int i = 0; i < t; i++){
			MoveVertical(-speedY);
			yield return null;
		}
		isMoving = false;
	}
}
