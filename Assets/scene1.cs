using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene1 : MonoBehaviour
{
    void Start()
    {
    // im using Cube as object 1 
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.name = "Cube";
        cube.transform.position = new Vector3(-1, 4, -1);
        cube.AddComponent<Rigidbody>();  

    // Sphere as object 2
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.name = "Sphere";
        sphere.transform.position = new Vector3(1, 3, 1); 
        sphere.AddComponent<Rigidbody>();  
    // Capsule as obj 3
        GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        capsule.name = "Capsule";
        capsule.transform.position = new Vector3(0, 2, 0);  // Position the capsule
        capsule.AddComponent<Rigidbody>(); 
    // Plane(Im calling it ground)
        GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Plane);
        ground.name = "Ground";
        ground.transform.position = new Vector3(0, 0, 0);  
        ground.transform.localScale = new Vector3(5, 5, 5);}

    void Update()
    {
        
    }
}
