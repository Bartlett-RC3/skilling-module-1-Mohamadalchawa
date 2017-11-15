using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session2 : MonoBehaviour {



	// Use this for initialization
	void Start () {

        condition();
		
	}

    void condition()
    {
        int value = 50;
        if (value == 50)
        {
            print("value is 50");
        }
        else
        {
            print("value is not 50");
        }

        for (int i = 0; i < 10; i++)
        {
            print("loop Value is " + i);
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
