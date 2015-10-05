using UnityEngine;
using System.Collections;

public class Shoot : AbstractBehaviour {

	[SerializeField] GameObject projectilePrefab;
	[SerializeField] Transform launcher;

	protected void ShootProjectile(){
		Instantiate(projectilePrefab, launcher.transform.position, launcher.transform.rotation);
	}
}
