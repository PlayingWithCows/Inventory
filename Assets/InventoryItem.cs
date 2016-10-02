using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InventoryItem : MonoBehaviour {

	public int itemID, amount;
	public string shortName, itemName;

	private Text numberText;

	void Start(){
		numberText = gameObject.GetComponentInChildren<Text> ();
		updateAmountText ();
	}



	public void addAmount(int changedAmount){
		amount += changedAmount;
		updateAmountText ();
	}
	public void reduceAmount(int changedAmount){
		amount -= changedAmount;
		updateAmountText ();
	}

	private void updateAmountText(){

		if (amount == 0) {
		
			numberText.text = "";

		} else {
			numberText.text = amount.ToString();
		}
			

	
	}

}
