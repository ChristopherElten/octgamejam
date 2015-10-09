using UnityEngine;
using System.Collections;

public class AutoFire : MonoBehaviour {

	[SerializeField] float secondsBetweenShots;
	protected Shoot shoot;

	protected void Awake(){
		shoot = GetComponent<Shoot>();
	}

	void Start(){
		InvokeRepeating("Fire", 2, secondsBetweenShots);
	}

	void Fire(){
		shoot.ShootProjectile();
	}
}
