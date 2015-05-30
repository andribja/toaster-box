using UnityEngine;
using System.Collections;

public class TurnOnFlashlight : MonoBehaviour {
	private Light lt;
	private int found;
	// Use this for initialization
	void Start () {
		lt = GetComponent<Light>();
		lt.intensity = 0;
	}

	public void turnOn() {
		found++;
		if (found >= 2)
			lt.intensity = 5;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
