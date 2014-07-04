using UnityEngine;
using System.Collections;
using UnityEngine.PSM;

public class SpawnCharacter : MonoBehaviour {
	public GameObject greenMan;
	private int spriteNum = 0;
	public int SpriteNum{ get{ return this.spriteNum; } }
	const float spanWaitVal = .2f;
	float spanWait;

	void Start () {
		spanWait = spanWaitVal;
	}

	void Update () {
		#if UNITY_EDITOR
		if (Input.GetMouseButtonDown(0)) {
			Vector3 createPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			createPos.z = 0;
			Instantiate(greenMan, createPos, Quaternion.identity);
			spriteNum++;
		}
		#else
		foreach (Touch touch in PSMInput.touchesSecondary) {
			if (touch.phase == TouchPhase.Began) {
				Vector3 createPos = Camera.main.ScreenToWorldPoint(PSMInput.touchesSecondary[0].position);
				createPos.z = 0;
				Instantiate(greenMan, createPos, Quaternion.identity);
				spriteNum++;
			}
		}
		#endif
		if (Input.GetButton("Spawn")) {
			spanWait -= Time.deltaTime;
			if (spanWait < 0) {
				Instantiate(greenMan, new Vector3(Random.Range(-1f, 1f), 3.2f, 0), Quaternion.identity);
				spriteNum++;
				spanWait = spanWaitVal;
			}
		}
	}
}
