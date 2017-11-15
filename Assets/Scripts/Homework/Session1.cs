
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
    public List<float> firstList;
    Dictionary<string,string> rc3Membeers = new Dictionary<string, string>();


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

        rc3Membeers.Add("slot1","jelena");
        rc3Membeers.Add("slot2","noura");

        print("The number of RC3 members added in this dictionary is "+ rc3Membeers.Count);
        print("They are " + rc3Membeers["slot1"] + " and " + rc3Membeers["slot2"]);

    }

	// Update is called once per frame
	void Update ()
	{


	}
}
