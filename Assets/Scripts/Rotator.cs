﻿using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {


	
	// Update is called once per frame
	void Update () 
	{
		// rotate the game object
		transform.Rotate (new Vector3 (0, 0, 45) * Time.deltaTime);
	}
}
