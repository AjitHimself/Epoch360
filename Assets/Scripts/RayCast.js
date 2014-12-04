// Prints the name of the object camera is directly looking at
	function Update () {
		// Get the ray going through the center of the screen
		var ray : Ray = camera.ViewportPointToRay (Vector3(0.5,0.5,0));
		// Do a raycast
		var hit : RaycastHit;
		var Bullseye : GameObject;
		if (Physics.Raycast (ray, hit))	{
			//Debug code
			Debug.DrawLine (ray.origin, hit.point);
			Bullseye = GameObject.Find("Bullseye");
			Bullseye.transform.position.x = hit.point.x;
			Bullseye.transform.position.y = hit.point.y;
			Bullseye.transform.position.z = hit.point.z;
			
		}	
	}