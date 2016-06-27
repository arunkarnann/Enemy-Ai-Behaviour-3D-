using UnityEngine;
using System.Collections;
/// <summary>
/// This Class contails all the Ai states / Behavour Scripts
/// </summary>
public class MoveRight : State {

	GameObject target;

	public   MoveRight(GameObject myGameObject):base (myGameObject){
		target = myGameObject;
	}

	public override void Update(){
		Debug.Log("walking right");
	}
	public override void Enter(){
		target.GetComponent<Enemy>().isMovingRight= true;
		Debug.Log("Entered Right");
	}
	public override void Exit(){
		target.GetComponent<Enemy>().isMovingRight= false;
		Debug.Log("Exit Right");
	}
}


public class MoveLeft : State {

	GameObject target;

	public   MoveLeft(GameObject myGameObject):base (myGameObject){
		target= myGameObject;
	}


	public override void Update(){
		Debug.Log("walking Left");
	}
	public override void Enter(){
		target.GetComponent<Enemy>().isMovingLeft=true;
		Debug.Log("Entered Left");
	}
	public override void Exit(){
		target.GetComponent<Enemy>().isMovingLeft=false;
		Debug.Log("Exit Left");
	}
}


public class Idle : State {

	GameObject target;

	public   Idle(GameObject myGameObject):base (myGameObject){
		target=myGameObject;
	}

	public override void Update(){
		Debug.Log("In Idle");
	}
	public override void Enter(){
		myGameObject.GetComponent<Enemy>().isIdle=true;
		Debug.Log("Entered Idle");
	}
	public override void Exit(){
		myGameObject.GetComponent<Enemy>().isIdle=false;
		Debug.Log("Exit Idle");
	}
}


public class Attack : State {

	GameObject target;

	public   Attack(GameObject myGameObject):base (myGameObject){
		target = myGameObject;
	}

	public override void Update(){
		//Move Right
		Debug.Log("Attacking now");
	}
	public override void Enter(){
		target.GetComponent<Enemy>().isAttacking=true;
		Debug.Log("Entered Attack");
	}
	public override void Exit(){
		target.GetComponent<Enemy>().isAttacking=false;
		Debug.Log("Exit Attack");
	}
}

