using UnityEngine;
using System.Collections;

public class PatrolState : IEnemyState {

	private readonly StatePatternEnemy enemy;


	public PatrolState(StatePatternEnemy statePatternEnemy){
		enemy = statePatternEnemy;
	}

	public void UpdateState(){
		Patrol();
	}
	
	public void OnTriggerEnter2D(Collider2D other){
		//To alert state if player enters boundary
		if (other.gameObject.CompareTag("Player")){
			enemy.StopCoroutine("Walk");
			enemy.wayPoint = Vector2.zero;
			enemy.chaseTarget = other.transform;
			ToAlertState();
		}
		//To chase state if civilian enters boundary
		if (other.gameObject.CompareTag("Civilian")){
			enemy.chaseTarget = other.transform;
			enemy.StopCoroutine("Walk");
			enemy.aim.changeTarget(enemy.chaseTarget);
			enemy.autoFire.enabled = true;
			ToChaseState();
		}
	}
	
	public void OnTriggerExit2D(Collider2D other){
		
	}
	
	public void ToPatrolState(){
		Debug.Log("Can't transition to self (PatrolState)");
	}
	
	public void ToAlertState(){
		enemy.currentState = enemy.alertState;
	}
	
	public void ToChaseState(){
		enemy.currentState = enemy.chaseState;
	}

	private void Patrol(){
		enemy.spriteRendererFlag.color = Color.green;
		if (enemy.wayPoint == Vector2.zero){
			enemy.wayPoint = enemy.transform.position + new Vector3(Random.Range(-enemy.walkRadius, enemy.walkRadius), Random.Range(-enemy.walkRadius, enemy.walkRadius), 0);
			enemy.StartCoroutine("Walk", enemy.wayPoint);
		}
	}
}
