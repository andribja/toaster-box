using UnityEngine;
using System.Collections;

public class PickUpFlashlight : MonoBehaviour {
	private Vector3 startingPosition;
	
	void Start() {
		//startingPosition = transform.localPosition;
		SetGazedAt(false);
	}
	
	public void SetGazedAt(bool gazedAt) {
		GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.red;
	}
	
	/*public void Reset() {
		transform.localPosition = startingPosition;
	}*/
	
	public void ToggleVRMode() {
		Cardboard.SDK.VRModeEnabled = !Cardboard.SDK.VRModeEnabled;
	}
	
	public void PickUp() {
		Destroy(gameObject);
	}
}
