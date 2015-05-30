// Copyright 2014 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEngine;
using System.Collections;


public class Teleport : MonoBehaviour {
	private Vector3 startingPosition;
	//private bool isAtStart = true;
	//private float lastClickTime;
	//private float DOUBLE_CLICK_TIME = 0.5f;

  void Start() {
	DontDestroyOnLoad (this.gameObject);
    startingPosition = transform.localPosition;
    SetGazedAt(false);
  }

  public void SetGazedAt(bool gazedAt) {
    GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.red;
  }

	public void ReturnToStart() { // go back to the middle
		transform.localPosition = new Vector3 (0, 4, 0);
		//isAtStart = true;
	}

  public void Reset() {
    transform.localPosition = startingPosition;
  }

  public void ToggleVRMode() {
    Cardboard.SDK.VRModeEnabled = !Cardboard.SDK.VRModeEnabled;
  }

  public void TeleportUnderCouch() { // zoom in under couch
		transform.localPosition = new Vector3 (-(float)3.5, (float)0.5, (float)1.2);
		// isAtStart = false;
  }

	public void TeleportToPaperclips() {
		transform.localPosition = new Vector3 (4.2f, 1.5f, 1.5f);
		// isAtStart = false;
	}

	public void TeleportToKey() {
		transform.localPosition = new Vector3 (3, 7, -4);
	}

	public void TeleportToPW() {
		transform.localPosition = new Vector3 (5, 5.5f, 4);
		// isAtStart = false;
	}

	void Update() {
		//nothing here yet
	}
}
