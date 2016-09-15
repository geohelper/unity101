using UnityEngine;
using System.Collections;

// Removes any object that is out of bounds
// Attach as component to a collider & resize to represent boundary
public class RemoveOuttaBounds : MonoBehaviour {
	
	// If object exits collider, destroy it
	void OnTriggerExit (Collider other) {
		Destroy(other.gameObject);
	}
}