using UnityEngine;
using System.Collections;

public class hand : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision col) {
		Debug.Log("Enter called..");
	}
	void OnCollisionStay(Collision col) {
		Debug.Log ("Stay occuring..");
	}
	void onCollisionExit(Collision collision) {
		Debug.Log ("Exit called..");
	}
}
