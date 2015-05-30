using UnityEngine;
using System.Collections;

public class TurnOnFlashlight : MonoBehaviour {
	private Light lt;
	private int found;
	private float intensity;
	public Flags flags;
	// Use this for initialization
	void Start () {
		lt = GetComponent<Light>();
		lt.intensity = 0;
		intensity = 5;
	}

	// Update is called once per frame
	void Update () {
		if (flags.flashlight >= 2)
			lt.intensity = intensity;
	}
}
