using UnityEngine;
using System.Collections;

public class Falling : MonoBehaviour {

	public float fallSpeed = 4.0f;
	//public float spinSpeed = 250.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
		//transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
	
	}
}
