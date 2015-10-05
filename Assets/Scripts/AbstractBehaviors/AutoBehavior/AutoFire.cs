using UnityEngine;
using System.Collections;

public class AutoFire : Shoot {

	[SerializeField] float secondsBetweenShots;

	void Start(){
		InvokeRepeating("ShootProjectile", 2, secondsBetweenShots);
	}
}
