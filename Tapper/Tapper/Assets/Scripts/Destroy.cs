using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour 
{

	float score = 0;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if ((Input.GetKey(KeyCode.Space)) == true)
		{
			Destroy (col.gameObject);
			Debug.Log (score += 1);

		}
	}
}
