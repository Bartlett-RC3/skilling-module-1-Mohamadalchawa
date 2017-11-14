using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4RayCasting : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
        // ray direction

	    Vector3 castedRayDirection = transform.TransformDirection(Vector3.forward);
        // store the object that is in front

	    RaycastHit objectInFront;


        // ray casting

	    if (Physics.Raycast(transform.position,castedRayDirection, out objectInFront ))
	    {
	        string objectInFrontName = objectInFront.transform.name;
	        Debug.Log("there is an object infront of me! Its name is :" + objectInFrontName);
            Destroy(objectInFront.transform.gameObject);
            
	    }
        // move the cube up
	    if (Input.GetKey(KeyCode.W))
	    {
	        transform.Translate(Vector3.up*0.1f);
	    }

	    if (Input.GetKey(KeyCode.S))
	    {
	        transform.Translate(Vector3.down * 0.1f);
	    }
    }
}
