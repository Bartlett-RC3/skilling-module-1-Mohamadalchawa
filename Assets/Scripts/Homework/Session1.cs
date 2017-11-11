
//References
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Session1 : MonoBehaviour {

    //Where code lives

    //1.Variables
    //Scope -- Type -- Name -- Value

    //Numbers
    public int myFirstIntegerNumber = 98; // make sure you end with ;
    float myFirstFloatNumber = 1.7f; //make sure theres an f.

    //Text
    public string myFirstString = "My text is here.";

    // Logical variable
    bool myFirstBoolean = true;


    // Data Structures
    //Scope -- Type -- Values
    //3.a.Arrays
    public int[] myIntegerArray = { 1, 2, 3, 4, 5 };
    public float[] myFloatArray = new float[5];

    //3.b.Lists
    public List<int> myIntegerList = new List<int>();

    //2.Functions

    // Scope -- Type -- Variables --Body (Instructions)

    // Use this for initialization
    void Start () {
        Debug.Log("Addition of 5 and 3 is: " + AdditionOfNumbers(5, 3));

        myFloatArray[2] = 3.2f;
        myFloatArray[4] = 5.6f;
        myFloatArray[1] = 9.2f;

        myIntegerList.Add(1);
        myIntegerList.Add(2);
        myIntegerList.Add(3);

    }

   
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Hello World!!");

		
	}

    int AdditionOfNumbers(int number1, int number2) //declaring a return type (integer)
    {
        int additionResult = number1 + number2;  //declaring the result (addition of the two vars)
        return additionResult;  // returning the result

    }
}
