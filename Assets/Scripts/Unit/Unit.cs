using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {
	
	void Start(){
		Debug.Log("Unit Spawned! Particles and what not go here!");
	}

	void OnDestroy(){
		Debug.Log("Unit Died! Particles and what not go here!");
	}
}
