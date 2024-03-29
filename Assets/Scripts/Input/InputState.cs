﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ButtonState{
	public bool value;
	public float holdTime = 0;
}

public enum DirectionsX {
	Right = 1, 
	Left = -1
}

public enum DirectionsY{
	Up = 1,
	Down = -1
}

public class InputState : MonoBehaviour {


	public DirectionsX directionX = DirectionsX.Right; // Facing right by default, artwork abides by this
	public DirectionsY directionY = DirectionsY.Up; // Facing right by default, artwork abides by this
	public Vector3 cursorPos;
	public float absVelX = 0f;
	public float absVelY = 0f;

	private Rigidbody2D body2D;
	private Dictionary<Buttons, ButtonState> buttonStates = new Dictionary<Buttons, ButtonState>();

	void Awake(){
		body2D = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate(){
		absVelX = Mathf.Abs(body2D.velocity.x);
		absVelY = Mathf.Abs(body2D.velocity.y);
	}

	public void SetButtonValue(Buttons key, bool value){
		if (!buttonStates.ContainsKey(key))
			buttonStates.Add(key, new ButtonState());

		var state = buttonStates[key];

		if (state.value && !value){
			state.holdTime = 0;
		} else if (state.value && value){
			state.holdTime += Time.deltaTime;
		}

		state.value = value;
	}

	public bool GetButtonValue(Buttons key){
		if(buttonStates.ContainsKey(key)){
			return buttonStates[key].value;
		} else {
			return false;
		}
	}

	public float GetButtonHoldTime(Buttons key){
		if(buttonStates.ContainsKey(key)){
			return buttonStates[key].holdTime;
		} else {
			return 0;
		}
	}
}
