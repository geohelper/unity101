using UnityEngine;
using System.Collections;

// Class with single method to call GameController's LoadLevel() Function

public class LevelLoader : MonoBehaviour {

	public void LoadLevel (string sceneToLoad){
		StartCoroutine (GameController.control.LoadLevel(sceneToLoad));
	}
}
