using UnityEngine;
using System.Collections;

public class startEnd : MonoBehaviour {

	// Use this for initialization

	// loading level 1

	public void StartLevel () 
		
	{
		Application.LoadLevel (1); 
		
	}

	//loading level 4

	public void EndLevel () 
		
	{
		Application.LoadLevel (4); 
		
	}

	
}
