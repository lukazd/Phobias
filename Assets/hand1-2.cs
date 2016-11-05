using UnityEngine;
using System.Collections;

public class hand12 : MonoBehaviour {
    public string part = "hand1-2";

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
		
		sampleChild = firebase.Child(part);
		//sampleChild.SetJsonValue("{\"hand-1\":{"\child_working\" : true}}");
		//sampleChild.SetValue("true");
		//sampleChild.SetBooleanValue(true);
		//firebase.SetValue ("SetValue working?");
		//firebase.SetJsonValue("{\"example_child":{\"child_working\" : true}}");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider col) {
		sampleChild.SetValue("true");
		Debug.Log("Enter: " + part);
	}

	void OnTriggerExit(Collider collision) {
		sampleChild.SetValue("false");
		Debug.Log ("Exit: " + part);
	}
}
