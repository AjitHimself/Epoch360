using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	public GameObject Panel1;
	void Start () {
		Panel1 = GameObject.Find ("Panel1");
	}
	void Update () {

	}
	void OnClick(){
		NGUITools.SetActive (Panel1, false);
	}
}
