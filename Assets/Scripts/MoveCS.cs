using UnityEngine;
using System.Collections;

public class MoveCS : MonoBehaviour {
	public float movementSpeed = 0.5f;
	public float turningSpeed = 60;
	public int flag = 0;
	public GameObject walkButton;
	public GameObject stopButton;
	public GameObject menuButton;
	public GameObject infoLabel;
	public GameObject changeWallColorButton;

	public GameObject redWall;
	public GameObject greyWall;
	public GameObject greenWall;
	public GameObject purpleWall;

	public GameObject room;

	public Color wallColor;

	public int layerMask = 1 << 8;

	void Start(){
		infoLabel = GameObject.Find("infoLabel");
		NGUITools.SetActive(infoLabel, false);

		changeWallColorButton = GameObject.Find ("changeWallColorButton");
		NGUITools.SetActive (changeWallColorButton, false);

		room = GameObject.Find ("room");
	}

	// Update is called once per frame
	void Update () { 
		
		Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit, layerMask)) {
						//Debug code
						Debug.DrawLine (ray.origin, hit.point, Color.blue);
						if (hit.distance > 1)
						if (flag == 1) {
								startMove ();
						}
		}
		else {
			if (flag == 1) {
				startMove ();
			}
		}

		UIEventListener.Get(walkButton).onClick += WalkClickFunction;
		UIEventListener.Get(stopButton).onClick += StopClickFunction;
		UIEventListener.Get(menuButton).onClick += MenuClickFunction;

		UIEventListener.Get(redWall).onClick += RedWallClickFunction;
		UIEventListener.Get(greyWall).onClick += GreyWallClickFunction;
		UIEventListener.Get(greenWall).onClick += GreenWallClickFunction;
		UIEventListener.Get(purpleWall).onClick += PurpleWallClickFunction;
	}

	public void WalkClickFunction(GameObject g){
		NGUITools.SetActive (changeWallColorButton, false);
		if(flag==0){flag=1;}
	}
	public void StopClickFunction(GameObject g){
		NGUITools.SetActive (changeWallColorButton, false);
		if(flag==1){flag=0;}
	}
	public void MenuClickFunction(GameObject g){
		NGUITools.SetActive (changeWallColorButton, true);
	}
	public void RedWallClickFunction(GameObject g){
		wallColor = redWall.GetComponent<UIButton> ().defaultColor;
		room.renderer.materials[1].color = wallColor;
	}
	public void GreyWallClickFunction(GameObject g){
		wallColor = greyWall.GetComponent<UIButton> ().defaultColor;
		room.renderer.materials[1].color = wallColor;		
	}
	public void GreenWallClickFunction(GameObject g){
		wallColor = greenWall.GetComponent<UIButton> ().defaultColor;
		room.renderer.materials[1].color = wallColor;
	}
	public void PurpleWallClickFunction(GameObject g){
		wallColor = purpleWall.GetComponent<UIButton> ().defaultColor;
		room.renderer.materials[1].color = wallColor;
	}
	public void startMove(){
		transform.position += transform.forward * Time.deltaTime * movementSpeed;
	}
}
