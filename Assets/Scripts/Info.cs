using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Info : MonoBehaviour {
	public GUISkin skin;
	SpawnCharacter spawn;
	
	int frameCount = 0;
	float dt = 0;
	float fps = 0;
	float updateRate = 4f;

	// Use this for initialization
	void Start () {
		GameObject go = GameObject.FindGameObjectWithTag("GameController");
		spawn = go.GetComponent<SpawnCharacter>();
	}

	void Update () {
		frameCount++;
		dt += Time.deltaTime;
		if (dt > 1.0f/updateRate)
		{
			fps = frameCount / dt ;
			frameCount = 0;
			dt -= 1.0f/updateRate;
		}
	}
	
	void OnGUI () {
		GUI.skin = skin;
		string txt;
		txt = System.String.Format("{0:F2} FPS", fps);
		GUI.Label(new Rect(10, 5, 160, 40), txt);
		txt = "SpriteNum : " + spawn.SpriteNum;
		GUI.Label(new Rect(175, 5, 300, 40), txt);
	}
}
