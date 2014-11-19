using UnityEngine;
using System.Collections;

public class RayCast : MonoBehaviour {

	void Update () {
		// Casting ray from center of camera
		Ray ray = camera.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit))

			print("I'm looking at " + hit.transform.name);
		else
			print("I'm looking at nothing!");
	}
}
