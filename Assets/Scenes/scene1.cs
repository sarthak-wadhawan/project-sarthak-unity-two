using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenebuilder : MonoBehaviour
{
    void Start()
    {
    // im using Cube as object 1 
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.name = "Cube";
        cube.transform.position = new Vector3(-1, 4, -1);
        cube.AddComponent<Rigidbody>();  
        cube.AddComponent<BoxCollider>();
        BoxCollider cubeCollider = cube.AddComponent<BoxCollider>();
        cubeCollider.center = new Vector3(1, 2, 1); 
        cubeCollider.size = new Vector3(1, 1, 1);
        
    // Sphere as object 2
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.name = "Sphere";
        sphere.transform.position = new Vector3(1, 3, 1); 
        sphere.AddComponent<Rigidbody>();  
        sphere.AddComponent<SphereCollider>();
        SphereCollider sphereCollider = sphere.AddComponent<SphereCollider>();
        sphereCollider.center = new Vector3(1, 2, 1); 
        sphereCollider.radius = 0.5f; 

    // Capsule as obj 3
        GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        capsule.name = "Capsule";
        capsule.transform.position = new Vector3(0, 2, 0);  
        capsule.AddComponent<Rigidbody>();
        capsule.AddComponent<CapsuleCollider>();
        CapsuleCollider capsuleCollider = capsule.AddComponent<CapsuleCollider>();
        capsuleCollider.center = new Vector3(1, 2, 1);  
        capsuleCollider.radius = 0.5f;                   
        capsuleCollider.height = 2; 

    
    // Plane(Im calling it ground)
        GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Plane);
        ground.name = "Ground";
        ground.transform.position = new Vector3(0, 0, 0);  
        ground.transform.localScale = new Vector3(5, 5, 5);}
        

    void Update()
    {
        
    }
    
}
