#pragma strict
	var target : Transform;
 	var distance : float;
 	var distance_y : float;
	
function Update () {
 	
     transform.position.z = target.position.z + distance;
     transform.position.y = target.position.y - distance_y;
     transform.position.x = target.position.x + distance;
 
}