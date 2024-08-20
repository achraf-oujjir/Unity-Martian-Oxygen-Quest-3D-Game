using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OTank : MonoBehaviour
{
	public void OnTriggerEnter(Collider other)
	{
		PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

		if (playerInventory != null)
		{
			playerInventory.TankCollected();
			gameObject.SetActive(false);
		}
	}

}
