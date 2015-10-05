using UnityEngine;
using System.Collections;

public class CursorShoot : Shoot {

	void Update () {
		var shooting = inputState.GetButtonValue(inputButtons[0]);

		if (shooting){
			ShootProjectile();
		}

	}
}
