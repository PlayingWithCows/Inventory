using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ActionBar : MonoBehaviour {
	private Transform hotBarWindow;

	public int hotBarSlotsNumber = 8;
	public List<Transform> hotBarSlots;
	public Transform hotBarSlot, inventoryItem;
	// Use this for initialization
	void Start () {
		hotBarWindow = GameObject.Find ("HotbarPanel").transform;

		for(int i = 0; i<hotBarSlotsNumber; i++){
			Transform newSlot = Instantiate(hotBarSlot);
			newSlot.transform.SetParent(hotBarWindow);
			newSlot.transform.name = "Inventory Slot " + i;
			hotBarSlots.Add (newSlot);
		}

	}

}
