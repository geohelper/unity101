using UnityEngine;
using System.Collections;

// Class with method to alter an objects Y position

public class Heightener : MonoBehaviour {

	public void Heighten() {
		transform.Translate(0, 0.25f, 0);
		Debug.Log("Heightened to " + transform.position.y);
	}

	public void Lower() {
		transform.Translate(0, -0.25f, 0);
		Debug.Log("Lowered to " + transform.position.y);
	}

}
