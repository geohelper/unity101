using UnityEngine;
using System.Collections;

// Class with single method to call GameController's LoadLevel() Function

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
