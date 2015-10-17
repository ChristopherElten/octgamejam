using UnityEngine;
using System.Collections;

public class ChaseState : IEnemyState {

	private readonly StatePatternEnemy enemy;

	public ChaseState(StatePatternEnemy statePatternEnemy){
		enemy = statePatternEnemy;
	}
	
	public void UpdateState(){
		Chase ();
	}
	
	public void OnTriggerEnter2D(Collider2D other){
		
	}
	
	public void OnTriggerExit2D(Collider2D other){
		
	}

	public void ToPatrolState(){
		ResetUnit();
		enemy.currentState = enemy.patrolState;
	}
	
	public void ToAlertState(){
		ResetUnit();
		enemy.currentState = enemy.alertState;
	}
	
	public void ToChaseState(){
		Debug.Log("Can't transition to self (ChaseState)");	
	}


	private void Chase(){
		enemy.spriteRendererFlag.color = Color.red;
		//Checking if target was destroyed
		if (enemy.chaseTarget == null){
			ToPatrolState();
		} else if (Vector2.Distance(enemy.transform.position, enemy.chaseTarget.position) > enemy.distanceFromTarget){
			//Go To target if not close enough...
			enemy.transform.position = Vector2.MoveTowards(new Vector2(enemy.transform.position.x, enemy.transform.position.y), 
			                                               new Vector2(enemy.chaseTarget.position.x, enemy.chaseTarget.position.y),
			                                               enemy.chaseSpeed * Time.deltaTime);
		}
	}

	private void ResetUnit(){
		enemy.chaseTarget = null;
		enemy.autoFire.enabled = false;
	}
}
