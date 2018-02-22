using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
	private Rigidbody rb;
	public float speed;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.velocity = transform.forward*speed;
	}

	private void Update()
	{
		if (rb.gameObject.transform.position.z <= -10||rb.gameObject.transform.position.z >= 20)
		{
			Destroy(rb.gameObject);
		}
	}
}
