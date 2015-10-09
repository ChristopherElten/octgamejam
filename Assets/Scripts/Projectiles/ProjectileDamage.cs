using UnityEngine;
using System.Collections;

public class ProjectileDamage : MonoBehaviour {

	[SerializeField] bool damagePlayer;
	[SerializeField] bool damageEnemy;

	[SerializeField] int strength;

	void OnTriggerEnter2D(Collider2D other){
		if ((other.gameObject.tag == "Enemy" && damageEnemy) || (other.gameObject.tag == "Player" && damagePlayer)){
			other.gameObject.SendMessage("ApplyDamage", strength);
			Destroy(this.gameObject);
		}
	}
}
