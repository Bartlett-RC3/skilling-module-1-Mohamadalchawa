
//References
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Session1 : MonoBehaviour {

    //Where code lives
    private int firstInteger = 3;
    private float firstFloat = 1.5f;
    private string firstString = "These are the declared variables : ";
    public int[] firstArray;
    private List<float> firstList;

    // Use this for initialization
    void Start ()
    {
        Debug.Log(firstString);
        Debug.Log(firstFloat);
        Debug.Log(firstInteger);

        firstArray = new int[10];

        firstArray[1] = 6;
        firstArray[6] = 10;
        firstList = new List<float>();
        firstList.Add(4);
        firstList.Add(3);

    }

	// Update is called once per frame
	void Update ()
	{


	}
}
