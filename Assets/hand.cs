using UnityEngine;
using System.Collections;

public class hand : MonoBehaviour {
    public string part = "NONE";

	IFirebase firebase;
	IFirebase sampleChild;
	
	
	// Use this for initialization
	void Awake () {
	    firebase = Firebase.CreateNew("https://phobias-af4c5.firebaseio.com/");
		Debug.Log("inAwake");

		firebase.ChildAdded += (object sender, FirebaseChangedEventArgs e) => {
			Debug.Log ("Child added!");
		};

		firebase.ChildRemoved += (object sender, FirebaseChangedEventArgs e) => {
			Debug.Log ("Child removed!");
		};
		
		sampleChild = firebase.Child("hand-1");
		sampleChild.SetValue(true);
		//sampleChild.SetBooleanValue(true);
		//firebase.SetValue ("SetValue working?");
		//firebase.SetJsonValue("{\"example_child\":{\"child_working\" : true}}");
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
