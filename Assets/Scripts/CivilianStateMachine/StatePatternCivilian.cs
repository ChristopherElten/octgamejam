using UnityEngine;
using System.Collections;

public class StatePatternCivilian : MonoBehaviour {

	[HideInInspector] public ICivilianState currentState;
	[HideInInspector] public ScatterState scatterState;
	
	public float walkSpeed = 0.003f;
	public float pauseDuration = 1f;
	public float walkRadius = 2f;
	public SpriteRenderer spriteRendererFlag;
	public Vector2 wayPoint;

	private void Awake(){
		scatterState = new ScatterState(this);
	}

	void Start () {
		currentState = scatterState;	
	}
	
	void Update () {
		currentState.UpdateState();
	}

	IEnumerator Walk(Vector2 target){
		while(Vector2.Distance(transform.position, target)>0.1f){
			transform.position = Vector3.MoveTowards (transform.position, target, walkSpeed);
			yield return null;
			
		}
		yield return new WaitForSeconds(pauseDuration);
		wayPoint = Vector2.zero;
	}

	private void OnTriggerEnter2D(Collider2D other){
		currentState.OnTriggerEnter2D(other);
	}
	
	private void OnTriggerExit2D(Collider2D other){
		currentState.OnTriggerExit2D(other);
	}
}
