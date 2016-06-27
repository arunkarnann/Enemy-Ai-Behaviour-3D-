using UnityEngine;
using System.Collections;

public abstract class State  {
	protected GameObject myGameObject;

	public State (GameObject gameObject){
		this.myGameObject = gameObject;
	}

	public abstract void Update();
	public abstract void Enter();
	public abstract void Exit();

}
