using UnityEngine;
using System.Collections;

public class StateMachineController : MonoBehaviour {

	State currentState;

	void Update(){
		if(currentState!=null){
			currentState.Update();
		}
	}

	public void SwitchState(State newState){
		if(currentState!=null){
			currentState.Exit();
		}
		currentState = newState;
		if(newState!=null){
			currentState.Enter();
		}

	}
}
