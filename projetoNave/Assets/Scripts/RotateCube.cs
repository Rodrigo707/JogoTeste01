using UnityEngine;
using System.Collections;

public class RotateCube : MonoBehaviour {

	public float velocidade_x;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(velocidade_x, 50, 50) * Time.deltaTime);

		}
}
