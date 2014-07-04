using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	
	void OnGUI () {
		const float buttonHeight = 50f;
		float y = 5f;

		if (GUI.Button(new Rect(5, y, 100, buttonHeight), "2D - Box")) {
			Application.LoadLevel("Test2DBox");
		}
		
		y += buttonHeight + 10f;
		if (GUI.Button(new Rect(5, y, 100, buttonHeight), "2D - Circle")) {
			Application.LoadLevel("Test2DCircle");
		}
		
		y += buttonHeight + 10f;
		if (GUI.Button(new Rect(5, y, 100, buttonHeight), "2D - Polygon")) {
			Application.LoadLevel("Test2DPolygon");
		}
		
		y = 5f;
		if (GUI.Button(new Rect(110, y, 100, buttonHeight), "3D - Box")) {
			Application.LoadLevel("Test3DBox");
		}
		
		y += buttonHeight + 10f;
		if (GUI.Button(new Rect(110, y, 100, buttonHeight), "3D - Sphere")) {
			Application.LoadLevel("Test3DSphere");
		}
	}
}
