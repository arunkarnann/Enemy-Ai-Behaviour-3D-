using UnityEngine;
using System.Collections;

public class SimpleOneWayMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * 0.1f);
	}
}
