using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class streetSkyline : MonoBehaviour {

	public Text streetName;



	void Start () {

	}

	// update steet name in skyline scene

	void Update () {

		if (transform.position.x < -70 && transform.position.x > -100) {
			streetName.text = "E 12TH STREET";
		} 
		else if (transform.position.y > -30 && transform.position.y < -18 ) {
			streetName.text = "NATIONAL CITY BLVD";
		}
		else if (transform.position.x < 50 && transform.position.x > 30) {
			streetName.text = "E 16TH STREET";
		}
		else if (transform.position.y > -32 && transform.position.y < -28) {
			streetName.text = "D   AVE";
		}

		else {
			streetName.text = "";
		}

		// loads level 3

		if (transform.position.y< -32) {

			Debug.Log ("level loading");

			Application.LoadLevel(3);

		}

		// end the simulation the input key ESC is pressed

		if (Input.GetKey(KeyCode.Escape)) {

			Debug.Log ("level loading");

			Application.LoadLevel(3);

		}

	}



}
