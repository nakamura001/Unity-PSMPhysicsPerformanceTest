using UnityEngine;
using System.Collections;

public class ShowMenu : MonoBehaviour {
	void Update () {
		if (Input.GetButtonDown("Menu")) {
			Application.LoadLevel("Menu");
		}
	}
}
