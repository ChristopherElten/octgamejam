using UnityEngine;
using System.Collections;

public class AlertState : IEnemyState {

	private readonly StatePatternEnemy enemy;
	private float searchTimer;
	
	public AlertState(StatePatternEnemy statePatternEnemy){
		enemy = statePatternEnemy;
	}

	public void UpdateState(){
		Search();
	}
	
	public void OnTriggerEnter2D(Collider2D other){
		
	}

	public void OnTriggerExit2D(Collider2D other){
		//Returning to patrol state after Player exits within time frame
		if (other.CompareTag("Player")){
			ToPatrolState();
		}
	}

	public void ToPatrolState(){
		enemy.currentState = enemy.patrolState;
		searchTimer = 0f;
	}
	
	public void ToAlertState(){
		Debug.Log("Can't transition to self (AlertState)");	
	}
	
	public void ToChaseState(){
		enemy.currentState = enemy.chaseState;
		searchTimer = 0f;
	}
	
	private void Search(){
		enemy.spriteRendererFlag.color = Color.yellow;
		//alert for player timer
		searchTimer += Time.deltaTime;


		if (searchTimer >= enemy.searchingDuration){
			if (enemy.autoFire != null) enemy.autoFire.enabled = true;
			enemy.aim.changeTarget(enemy.chaseTarget);
			ToChaseState();
		}
	}
}
