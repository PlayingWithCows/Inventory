using UnityEngine;
using System.Collections;

public class CanvasManager : MonoBehaviour {
	private Canvas inventory, hotbar;
	private bool bagOpen = false;
	// Use this for initialization
	void Start () {
		inventory = GameObject.Find ("InventoryCanvas").GetComponent<Canvas>();
		hotbar = GameObject.Find ("HotbarCanvas").GetComponent<Canvas>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Inventory")) {

			if (bagOpen) 
			{
				inventory.enabled = false;
				bagOpen = false;
			}
			else
			{
				inventory.enabled = true;
				bagOpen = true;
			}

		}
	}
}
