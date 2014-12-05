// Prints the name of the object camera is directly looking at
	function Update () {
		// Get the ray going through the center of the screen
		var ray : Ray = camera.ViewportPointToRay (Vector3(0.5,0.5,0));
		// Do a raycast
		var hit : RaycastHit;
		var Bullseye : GameObject;
		var walkButton : GameObject;
		var stopButton : GameObject;
		var menuButton : GameObject;
		if (Physics.Raycast (ray, hit))	{
			//Debug code
			Debug.DrawLine (ray.origin, hit.point);
			// GameObjects initialized
			Bullseye = GameObject.Find("Bullseye");
			walkButton = GameObject.Find("walkButton");
			stopButton = GameObject.Find("stopButton");
			menuButton = GameObject.Find("menuButton");
			// Position change for pointer
			Bullseye.transform.position.x = hit.point.x;
			Bullseye.transform.position.y = hit.point.y;
			Bullseye.transform.position.z = hit.point.z;
			
			if(hit.collider.gameObject.transform.name == "walkButton")
			{	
				//walkButton.SendMessage("OnHover", true);
				walkButton.SendMessage("OnClick");
			}
			
			if(hit.collider.gameObject.transform.name == "stopButton")
			{
				//stopButton.SendMessage("OnHover", true);
				stopButton.SendMessage("OnClick");
			}
			
			if(hit.collider.gameObject.transform.name == "menuButton")
			{
				//menuButton.SendMessage("OnHover", true);
				menuButton.SendMessage("OnClick");
			}
			
		}	
	}
	