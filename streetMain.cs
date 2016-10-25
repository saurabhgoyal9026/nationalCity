using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class streetMain : MonoBehaviour {

	public Text streetName;

	void Start () {
	
	}
	
	// updating the steet name 

	void Update () {
	
		if (transform.position.z < 868 ) {
			streetName.text = "N EUCLID AVE";
		}
		else if (transform.position.z > 1080 ) {
			streetName.text = "S HARBISON AVE";
		}
		else if (transform.position.x < -1297 ) {
			streetName.text = "E DIVISION ST.";
		}
		else if (transform.position.x > -1194 ) {
			streetName.text = "E 4TH ST.";
		}

		else {
			streetName.text = "";
		}

		// loading level 3

		if (transform.position.x<-1350) {

			Debug.Log ("level loading");

			Application.LoadLevel(2);

		}

		//loading level 4

		if (Input.GetKey(KeyCode.Escape)) {
			
			Debug.Log ("level loading");
			
			Application.LoadLevel(3);
			
		}

	}

	// checking if collided with wall
			
	void OnTriggerStay(Collider other)
	{
		if (other.name == "wall_F") {
			
			Debug.Log("collided");
		}
		
	}
	
	
}
