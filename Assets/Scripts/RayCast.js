// Prints the name of the object camera is directly looking at
	var finished : boolean = false;
	var infoLabel : GameObject;
	
	function Update () {
		// Get the ray going through the center of the screen
		var ray : Ray = camera.ViewportPointToRay (Vector3(0.5,0.5,0));
		// Do a raycast
		var hit : RaycastHit;
		var Bullseye : GameObject;
		// Buttons declaration
		var walkButton : GameObject;
		var stopButton : GameObject;
		var menuButton : GameObject;
		var changeWallColorButton : GameObject;
		// wall color buttons
		var redWall : GameObject;
		var greyWall : GameObject;
		var greenWall : GameObject;
		var purpleWall : GameObject;
				
		if (Physics.Raycast (ray, hit))	{
			//Debug code
			Debug.DrawLine (ray.origin, hit.point, Color.red);
			// GameObjects initialized
			Bullseye = GameObject.Find("Bullseye");
			walkButton = GameObject.Find("walkButton");
			stopButton = GameObject.Find("stopButton");
			menuButton = GameObject.Find("menuButton");
			changeWallColorButton = GameObject.Find("changeWallColorButton");
			
			redWall = GameObject.Find("redWall");
			greyWall = GameObject.Find("greyWall");
			greenWall = GameObject.Find("greenWall");
			purpleWall = GameObject.Find("purpleWall"); 
			
			// Position change for pointer
			Bullseye.transform.position.x = hit.point.x;
			Bullseye.transform.position.y = hit.point.y;
			Bullseye.transform.position.z = hit.point.z;
			
			if(hit.collider.gameObject.transform.name == "walkButton")
			{	
				walkButton.SendMessage("OnHover", true);
				loadingTimer();
				if (finished == true){
				finished = false;
				walkButton.SendMessage("OnClick");
				}
			}
			
			else if(hit.collider.gameObject.transform.name == "stopButton")
			{
				stopButton.SendMessage("OnHover", true);
				loadingTimer();
				if (finished == true){
				finished = false;
				stopButton.SendMessage("OnClick");
				}
			}
			
			else if(hit.collider.gameObject.transform.name == "menuButton")
			{
				menuButton.SendMessage("OnHover", true);
				loadingTimer();
				if (finished == true){
				finished = false;
				menuButton.SendMessage("OnClick");
				}
			}
			
			else if(hit.collider.gameObject.transform.name == "changeWallColorButton")
			{
				changeWallColorButton.SendMessage("OnHover", true);
				changeWallColorButton.SendMessage("OnClick");
			}
			
			else if(hit.collider.gameObject.transform.name == "redWall")
			{
				redWall.SendMessage("OnClick");
			}
			
			else if(hit.collider.gameObject.transform.name == "greyWall")
			{
				greyWall.SendMessage("OnClick");
			}
			
			else if(hit.collider.gameObject.transform.name == "greenWall")
			{
				greenWall.SendMessage("OnClick");
			}
			
			else if(hit.collider.gameObject.transform.name == "purpleWall")
			{
				purpleWall.SendMessage("OnClick");
			}
			
			else 
			{
				walkButton.SendMessage("OnHover", false);
				stopButton.SendMessage("OnHover", false);
				menuButton.SendMessage("OnHover", false);
			}
			
		}	
	}
	
	function loadingTimer(){
		yield WaitForSeconds(3);
		finished = true;
	}
	