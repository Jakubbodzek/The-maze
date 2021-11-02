using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillingBlock : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("KillingBlock"))
		{
			transform.position = new Vector3(-17, 0, 0);
		}
	}
}
