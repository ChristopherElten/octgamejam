﻿using UnityEngine;
using System.Collections;

//Abstract behavior that every behavior will inherit.
public abstract class AbstractBehaviour : MonoBehaviour {

	public Buttons[] inputButtons;
	public MonoBehaviour[] dissableScripts;

	protected InputState inputState;
	protected Rigidbody2D body2D;
	protected CollisionState collisionState;

	protected virtual void Awake(){
		inputState = GetComponent<InputState>();
		body2D = GetComponent<Rigidbody2D>();
		collisionState = GetComponent<CollisionState>();
	}

	protected virtual void ToggleScripts(bool value){
		foreach(var script in dissableScripts){
			script.enabled = value;
		}
	}
}