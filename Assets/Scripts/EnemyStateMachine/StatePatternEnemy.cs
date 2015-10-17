using UnityEngine;
using System.Collections;

public class StatePatternEnemy : MonoBehaviour {


	public float searchingDuration = 4f;
	public float sightRange = 20f;
	public float chaseSpeed = 1f;
	public float walkRadius = 2f;
	public float walkSpeed = 0.003f;
	public float pauseDuration = 1f;
	public LayerMask unitLayerMask;
	public float distanceFromTarget = 2f;
	//Random positions instead of way points
	public SpriteRenderer spriteRendererFlag;

	[HideInInspector] public Transform chaseTarget;
	[HideInInspector] public IEnemyState currentState;
	[HideInInspector] public ChaseState chaseState;
	[HideInInspector] public AlertState alertState;
	[HideInInspector] public PatrolState patrolState;

	public Aim aim;
	public AutoFire autoFire;

	public Vector2 wayPoint;
	
	private void Awake(){
		chaseState = new ChaseState(this);
		alertState = new AlertState(this);
		patrolState = new PatrolState(this);
		aim = GetComponent<Aim>();
		autoFire = GetComponent<AutoFire>();
	}
	
	void Start () {
		currentState = patrolState;	
	}
	
	void Update () {
		currentState.UpdateState();
	}

	IEnumerator Walk(Vector2 target){
		while(Vector2.Distance(transform.position, target)>0.01f){
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
