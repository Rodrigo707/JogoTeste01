﻿using UnityEngine;
using System.Collections;

public class RotateHelice : MonoBehaviour {

	public float velocidade_y;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0, velocidade_y, 0) * Time.deltaTime);

		}
}
