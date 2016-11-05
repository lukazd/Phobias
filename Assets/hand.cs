using UnityEngine;
using System.Collections;

public class hand : MonoBehaviour {
    public string part = "NONE";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider col) {
		Debug.Log("Enter: " + part);
	}

	void OnTriggerExit(Collider collision) {
		Debug.Log ("Exit: " + part);
	}
}
