using UnityEngine;
using System.Collections;

//Abstract behavior that every behavior will inherit.
public abstract class AbstractBehaviour : MonoBehaviour {
	
	protected Rigidbody2D body2D;
	protected CollisionState collisionState;

	protected virtual void Awake(){
		body2D = GetComponent<Rigidbody2D>();
		collisionState = GetComponent<CollisionState>();
	}
}
