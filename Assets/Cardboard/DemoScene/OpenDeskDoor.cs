using UnityEngine;
using System.Collections;

public class OpenDeskDoor : MonoBehaviour {
	private Vector3 startingPosition;
	private float openSign = 0;
	private bool isOpening = false;
	private bool isOpen = false;
	private float currentRotation = 0;
	private float rightDoor = 1;
	
	void Start() {
		startingPosition = transform.localPosition;
		SetGazedAt(false);
	}
	
	public void SetGazedAt(bool gazedAt) {
		//GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.red;
	}
	
	public void Reset() {
		transform.localPosition = startingPosition;
	}
	
	public void ToggleVRMode() {
		Cardboard.SDK.VRModeEnabled = !Cardboard.SDK.VRModeEnabled;
	}
	
	public void OpenDoor(bool setRightDoor=false) {
		rightDoor = setRightDoor?-1:1;
		if(isOpening){
			return;
		}
		isOpening = true;
		openSign = rightDoor*(isOpen ? -1 : 1);
		isOpen = !isOpen;
	}

	public void Update() {
		if(isOpening){
			float rot = openSign*Time.deltaTime*30;
			currentRotation += rot;
			transform.Rotate(Vector3.forward*(rot));
			if(rightDoor == -1?currentRotation < -100:currentRotation > 100){
				transform.Rotate(Vector3.forward*(rightDoor*100-currentRotation));
				currentRotation = rightDoor*100;
				isOpen = true;
				isOpening = false;
				openSign = 0;
			} else if(rightDoor == -1?currentRotation>0:currentRotation < 0){
				transform.Rotate(Vector3.forward*(-currentRotation));
				currentRotation = 0;
				isOpen = false;
				isOpening = false;
				openSign = 0;
			}
		}
	}
}