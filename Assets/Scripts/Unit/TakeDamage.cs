using UnityEngine;
using System.Collections;

public class TakeDamage : MonoBehaviour {

	private Unit myUnit;

	void Awake(){
		myUnit = GetComponent<Unit>();
	}
	
	public void ApplyDamage(int damage){
		myUnit.health -= damage;
	}

}
