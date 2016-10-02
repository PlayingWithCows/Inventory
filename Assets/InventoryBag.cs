using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryBag : MonoBehaviour {


	private Transform inventoryWindow;

	public List<Transform> inventorySlots;
	public int inventorySize;
	public Transform inventorySlot, inventoryItem;
	// Use this for initialization
	void Start () {
		inventoryWindow = GameObject.Find ("InventoryWindow").transform;

		for(int i = 0; i<inventorySize; i++){
			Transform newSlot = Instantiate(inventorySlot);
			newSlot.transform.SetParent(inventoryWindow);
			newSlot.transform.name = "Inventory Slot " + i;
			inventorySlots.Add (newSlot);
		}
	
	}
	

}
