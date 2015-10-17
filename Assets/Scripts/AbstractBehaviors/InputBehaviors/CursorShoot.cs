using UnityEngine;
using System.Collections;

public class CursorShoot : MonoBehaviour {

	public Buttons[] inputButtons;

	protected InputState inputState;
	protected Shoot shoot;

	bool canShoot = true;

	[SerializeField] float shotsPerSecond;
	
	void Awake(){
		inputState = GetComponent<InputState>();
		shoot = GetComponent<Shoot>();
	}

	void Update () {
		var shooting = inputState.GetButtonValue(inputButtons[0]);

		if (shooting && canShoot){
			StartCoroutine(Fire());
		}
	}

	IEnumerator Fire(){
		canShoot = false;
		shoot.ShootProjectile();
		yield return new WaitForSeconds(1/shotsPerSecond);
		canShoot = true;
	}
}
