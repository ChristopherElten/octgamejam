using UnityEngine;
using System.Collections;

public class ProjectileBehavior : MonoBehaviour {

	[SerializeField] float speed;

	void Update(){
		transform.position += transform.up*speed;
	}
}
