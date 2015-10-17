using UnityEngine;
using System.Collections;

public class TakeDamage : MonoBehaviour {

	[SerializeField] int health;

	public void ApplyDamage(int damage){
		health -= damage;

		if (health <= 0){
			Destroy(transform.parent.gameObject);
		}
	}

}
