using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	[SerializeField] protected GameObject projectilePrefab;
	[SerializeField] protected Transform launcher;

	public virtual void ShootProjectile(){
		Instantiate(projectilePrefab, launcher.transform.position, launcher.transform.rotation);
	}
}
