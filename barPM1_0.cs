using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class barPM1_0 : MonoBehaviour {

	

	// for vertical bar PM 1.0

	public RectTransform healthTransform_vertical;
	private float cachedX;
	private float minYValue;
	private float maxYValue;
	private int currentHealth_vertical;
	
	private int CurrentHealth_vertical
	{
		get { return currentHealth_vertical;}
		set{
			currentHealth_vertical = value;
			HandlePercentage ();
		}
	}
	
	public int maxHealth_vertical;
	public Text healthText_vertical;
	public Image visualHealth_vertical;
	public float coolDown_vertical;
	private bool onCD_vertical;

	
	void Start () {
	
	
		// for vertical bar 1

		cachedX = healthTransform_vertical.position.x;
		maxYValue = healthTransform_vertical.position.y;
		minYValue = healthTransform_vertical.position.y - healthTransform_vertical.rect.height ;
		currentHealth_vertical = maxHealth_vertical;
		onCD_vertical = false;

	}
	
	// Update is called once per frame

	void Update () {

		// FOR LEVEL 1

		if (Application.loadedLevel == 1) {
			if (transform.position.x > -1310 && transform.position.x < -1290 && transform.position.y > 65 && transform.position.y < 66) {
				// DATA POINT 4
				CurrentHealth_vertical = 13;
				healthText_vertical.text = "% PM 1.0 : 11660 ";
			} else if (transform.position.x > -1310 && transform.position.x < -1290 && transform.position.y > 66 && transform.position.y < 67) {
				// DATA POINT 2
				CurrentHealth_vertical = 16;

			} else if (transform.position.x > -1310 && transform.position.x < -1290 && transform.position.y > 67 && transform.position.y < 68) {
				// DATA POINT 3
				CurrentHealth_vertical = 22;

			} else if (transform.position.x < -1320) {
				// DATA POINT 1
				CurrentHealth_vertical = 82;
				healthText_vertical.text = "% PM 1.0 :31376  ";

			} else if (transform.position.x < -1285 && transform.position.x > -1320) {
				// DATA POINT 5
				CurrentHealth_vertical = 20;

			} else if (transform.position.x < -1275 && transform.position.x > -1285) {
				// DATA POINT 6
				CurrentHealth_vertical = 15;

			} else if (transform.position.x < -1250 && transform.position.x > -1275) {
				// DATA POINT 7
				CurrentHealth_vertical = 20;

			} else if (transform.position.x < -1185 && transform.position.x > -1250) {
				// DATA POINT 8
				CurrentHealth_vertical = 15;

			} else if (transform.position.x > -1190 && transform.position.x < -1150 && transform.position.y < 64 && transform.position.y > 63) {
				// DATA POINT 9
				CurrentHealth_vertical = 34;

			} else if (transform.position.x > -1190 && transform.position.x < -1150 && transform.position.y < 63 && transform.position.y > 62) {
				// DATA POINT 10
				CurrentHealth_vertical = 43;

			} else {
				CurrentHealth_vertical = 0;
				healthText_vertical.text = "% PM 1.0 ";
			}
		} else if (Application.loadedLevel == 2) {

			// FOR LEVEL 2

			if (transform.position.x < -70 && transform.position.x > -100 && transform.position.y > -21.5 && transform.position.y < -20.5) {
				// DATA POINT 1
				CurrentHealth_vertical = 36;

			} else if (transform.position.x < -70 && transform.position.x > -100 && transform.position.y > -20.5 && transform.position.y < -19.5) {
				// DATA POINT 2
				CurrentHealth_vertical = 59;

			} else if (transform.position.x < -70 && transform.position.x > -100 && transform.position.y > -19.5 && transform.position.y < -18.5) {
				// DATA POINT 3
				CurrentHealth_vertical = 63;

			} else if (transform.position.x < -70 && transform.position.x > -100 && transform.position.y > -18.5 && transform.position.y < -17.5) {
				// DATA POINT 4
				CurrentHealth_vertical = 43;

			} else if (transform.position.x < -50 && transform.position.x > -90 && transform.position.y > -30 && transform.position.y < -18) {
				// DATA POINT 5
				CurrentHealth_vertical = 66;

			} else if (transform.position.x < 15 && transform.position.x > -50 && transform.position.y > -30 && transform.position.y < -18) {
				// DATA POINT 6
				CurrentHealth_vertical = 37;

			} else if (transform.position.x < 50 && transform.position.x > 15 && transform.position.y > -30 && transform.position.y < -28) {
				// DATA POINT 7
				CurrentHealth_vertical = 71;

			} else if (transform.position.x < 50 && transform.position.x > 30 && transform.position.y > -29 && transform.position.y < -26) {
				// DATA POINT 8
				CurrentHealth_vertical = 37;

			} else if (transform.position.x < 50 && transform.position.x > 30 && transform.position.y > -30 && transform.position.y < -29) {
				// DATA POINT 9
				CurrentHealth_vertical = 38;

			} else if (transform.position.x < 50 && transform.position.x > 30 && transform.position.y > -31 && transform.position.y < -30) {
				// DATA POINT 10
				CurrentHealth_vertical = 39;

			} else if (transform.position.x < 40 && transform.position.x > 0 && transform.position.y > -32 && transform.position.y < -28) {
				// DATA POINT 11
				CurrentHealth_vertical = 49;

			} else if (transform.position.x < 0 && transform.position.x > -55 && transform.position.y > -32 && transform.position.y < -28) {
				// DATA POINT 12
				CurrentHealth_vertical = 20;

			}
				

		}
	
	}

	private void HandlePercentage()
	{



		// for vertical bar 1

		healthText_vertical.text = "% PM 1.0 :  " + currentHealth_vertical;
		
		float currentYValue = MapValues(currentHealth_vertical, 0, maxHealth_vertical, minYValue, maxYValue);
		
		healthTransform_vertical.position = new Vector3 (cachedX,currentYValue);
		
		if (currentHealth_vertical >= maxHealth_vertical / 2) {
			
			visualHealth_vertical.color = new Color32(255,(byte)MapValues(currentHealth_vertical,0,maxHealth_vertical/2,255,0),0,255);
			
		} else {
			
			
			visualHealth_vertical.color = new Color32((byte)MapValues(currentHealth_vertical,maxHealth_vertical/2,maxHealth_vertical,0,255),255,0,255);
			
			
		}

		
	}

	IEnumerator coolDownDmg()
	{

		onCD_vertical = true;
		yield return new WaitForSeconds (coolDown_vertical);
		onCD_vertical = false;
	}



	private float MapValues(float x , float inMin, float inMax , float outMin , float outMax)
	{
		return(x - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
	}


}
