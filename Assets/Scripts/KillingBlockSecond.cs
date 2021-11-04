using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillingBlockSecond : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("KillingBlock"))
		{
			transform.position = new Vector3(-18, 0, 0);
		}
	}
}
