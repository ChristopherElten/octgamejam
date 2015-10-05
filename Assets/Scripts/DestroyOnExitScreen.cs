using UnityEngine;
using System.Collections;

public class DestroyOnExitScreen : MonoBehaviour {

	void OnBecameInvisible(){
		Destroy(this.gameObject);
	}
}
