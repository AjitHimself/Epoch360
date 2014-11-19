#pragma strict

public var Highlighted = false;
   
function Awake (){
    gameObject.tag="Highlightable";
}
 
function Update () {
    var shader1 = Shader.Find( "Diffuse" );
    var shader2 = Shader.Find( "Self-Illumin/Diffuse" );
   
    if (Highlighted==true)
        renderer.material.shader = shader2;
    else
        renderer.material.shader = shader1;
}
 
function LateUpdate()
{
    Highlighted = false;
}