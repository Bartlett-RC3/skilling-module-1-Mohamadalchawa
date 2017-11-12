using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1_Assignment : MonoBehaviour {


    // Declaring an integer

    public int x = 68;
    // declaring a float variable
    public float y = 2.3f;
    // declaring a string
    public string string1 = "declaredString";
    // Creating a the printing function
    void print()
    {
        Debug.Log(x);
    }
    //Declaring the array
    public int[] declaredArray = new int[8];
    //Declaring a list
    public List<int> declaredList = new List<int>();

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
