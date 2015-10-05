﻿using UnityEngine;
using System.Collections;

public class Aim : AbstractBehaviour {
	
	[SerializeField] protected Transform itemBeingAimed;
	[SerializeField] protected Transform target;

	protected virtual void Update () {
		itemBeingAimed.rotation = Quaternion.Euler(0f, 0f, GetRotZ(target.position) - 90);
	}

	protected float GetRotZ(Vector3 target){
		Vector3 diff = target - transform.position;
		diff.Normalize();

		return Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
	}
}
