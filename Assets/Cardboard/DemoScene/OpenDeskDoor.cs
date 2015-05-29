using UnityEngine;
using System.Collections;

public class OpenDeskDoor : MonoBehaviour {
	private Vector3 startingPosition;
	private bool isOpening = false;
	private float timer = 0;
	private int isOpen = 1; // 1 = closed -1 = open
	
	void Start() {
		startingPosition = transform.localPosition;
		SetGazedAt(false);
	}
	
	public void SetGazedAt(bool gazedAt) {
		GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.red;
	}
	
	public void Reset() {
		transform.localPosition = startingPosition;
	}
	
	public void ToggleVRMode() {
		Cardboard.SDK.VRModeEnabled = !Cardboard.SDK.VRModeEnabled;
	}
	
	public void OpenDoor() {
		isOpening = true;
	}

	public void Update() {
		if (isOpening) {
			timer += Time.deltaTime;
			transform.Rotate(0, 0, isOpen*2*Time.deltaTime);
		}
		if(timer > 50) {
			isOpening = false;
			timer = 0;
			isOpen = -isOpen;
		}
	}
}