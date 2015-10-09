using UnityEngine;
using System.Collections;

public class TakeDamage : MonoBehaviour {

	int health;

	public void ApplyDamage(int damage){
		health -= damage;

		if (health <= 0){
			Destroy(this.gameObject);
		}
	}

}
