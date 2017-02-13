using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player; // for player

	private Vector3 offset; // for distance between the camera and player

	// Use this for initialization
	void Start () 
	{
		// initialize the offset as the value when the game starts
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		// move the camera to the new player's position + offset
		transform.position = player.transform.position + offset;
	}
}
