using UnityEngine;
using System.Collections;

public class ScatterState : ICivilianState {

	private readonly StatePatternCivilian civilian;

	public ScatterState(StatePatternCivilian statePatternCivilian){
		civilian = statePatternCivilian;
	}

	public void UpdateState(){
		Scatter ();
	}
	
	public void OnTriggerEnter2D(Collider2D other){
		
	}

	public void OnTriggerExit2D(Collider2D other){

	}

	public void ToScatterState(){
		Debug.Log("Can't transition to self (ScatterState)");
	}

	
	private void Scatter(){
		civilian.spriteRendererFlag.color = Color.green;
		if (civilian.wayPoint == Vector2.zero){
			civilian.wayPoint = civilian.transform.position + new Vector3(Random.Range(-civilian.walkRadius, civilian.walkRadius), Random.Range(-civilian.walkRadius, civilian.walkRadius), 0);
			civilian.StartCoroutine("Walk", civilian.wayPoint);
		}
	}
}
