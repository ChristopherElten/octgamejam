using UnityEngine;
using System.Collections;

public class SpreadShoot : Shoot {

	public int level;

	public override void ShootProjectile(){
		
		Instantiate(projectilePrefab, launcher.transform.position, launcher.transform.rotation);

		for(int i = 0; i <= level; i++){
			Instantiate(projectilePrefab, launcher.transform.position, launcher.transform.rotation*Quaternion.Euler(0, 0, i*20));
			Instantiate(projectilePrefab, launcher.transform.position, launcher.transform.rotation*Quaternion.Euler(0, 0, i*-20));
		}
	}
}
