using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float speed;
	
	private Rigidbody rb;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Coletaveis"))
			Destroy(other.gameObject);
		//	other.gameObject.SetActive (false);
				Debug.Log("Ta Certo Fera .!");
		
	}



 /*	function Update () {
		var enemies = GameObject.FindGameObjectsWithTag (“enemy”);
		var counter = GameObject.Find(“enemies counter”);
		counter.guiText.text = “enemies found : ” + enemies.length;
	}
*/
}
		

/*public class ExampleClass : MonoBehaviour {
     	void OnTriggerEnter(Collider other) {
	 		Destroy(other.gameObject);
	} */