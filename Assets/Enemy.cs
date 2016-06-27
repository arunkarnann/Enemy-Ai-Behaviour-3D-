using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	[SerializeField]
	float distanceIdle;
	[SerializeField]
	float distanceMove;
	[SerializeField]
	float distanceAttack;

	public GameObject player;
	bool isPlayerNear;
	[SerializeField]
	float distanceBetweenthis;

	public  bool isMovingRight;
	public  bool isMovingLeft;
	public  bool isIdle;
	public  bool isAttacking;

	[SerializeField]
	float distanceWithSide;
	void Update () {
		
		distanceBetweenthis = Vector3.Distance(this.transform.position,player.transform.position) ;

		if(distanceBetweenthis > distanceAttack){
			
			if(distanceBetweenthis > distanceMove){
				if(!isIdle){
					GetComponent<StateMachineController>().SwitchState(new Idle(this.gameObject));
				}
			}
			else{
				//Returns positive when player is in Left side and negative When Player is in Right side
				distanceWithSide = transform.InverseTransformPoint(player.transform.position).x;
				if(distanceWithSide > 0 && !isMovingRight){
					GetComponent<StateMachineController>().SwitchState(new MoveRight(this.gameObject));
				}
				if (distanceWithSide < 0 && !isMovingLeft){
					GetComponent<StateMachineController>().SwitchState(new MoveLeft(this.gameObject));
				}
			}
		}
		else if(!isAttacking){
			GetComponent<StateMachineController>().SwitchState(new Attack(this.gameObject));
		}
	}
}
