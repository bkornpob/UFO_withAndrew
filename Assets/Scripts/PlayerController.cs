using UnityEngine;
using System.Collections;
using UnityEngine.UI; // for UI text

public class PlayerController : MonoBehaviour {

	public float speed; // for adjusting player movement speed
	public Text countText; // for count score
	public Text winText; // for win text

	private Rigidbody2D rb2d; // for moving player
	private int count; // for count score

	// for initialization
	void Start()
	{
		rb2d = GetComponent<Rigidbody2D> ();
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	void FixedUpdate()
	{
		// moving player
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb2d.AddForce (movement * speed);
	}
		
	void OnTriggerEnter2D(Collider2D other)
	{
		// OnTriggerEnter with PickUp, deactivate the PickUp, count score, and display score.
		if (other.gameObject.CompareTag ("PickUp")) 
		{
			other.gameObject.SetActive (false);
			count += 1;
			SetCountText ();
		}


	}

	// for displaying count score
	void SetCountText()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 12) 
		{
			winText.text = "You win.";
		}
	}

}
