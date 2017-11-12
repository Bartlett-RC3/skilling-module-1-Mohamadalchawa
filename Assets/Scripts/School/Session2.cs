using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session2 : MonoBehaviour {

    //Session2 : condititonal loops and classes
    // UCL RC3 12nov2017
    // variables
   public int myNumber = 2;
   public bool questionTime = false;
    int myVariableQuestionTime;

    string[] fruites = { "banana", "apple", "mango", "blueberry" };
    List<int> evenNumbers = new List<int>();
    int[] evenNumbersSmart = new int[10];


	// Use this for initialization
	void Start () {

        // conditionals

        //normal if statement
        if (myNumber == 2)
        {
            Debug.Log("your number is equal to 2.");
        }
        else
        {
            Debug.Log("your number is not equal to 2.");
        }
        //short if statement
        if (questionTime == true)
        {
            Debug.Log("Question Time is true.");
        }
        else
        {
            Debug.Log("Question Time is false.");
        }

        //variable name is equal to either 1 or 0 based on the value of the question
        myVariableQuestionTime = (questionTime) ? 1 : 0;
        Debug.Log("the value of myVariableQuestionTime is:" + myVariableQuestionTime);

        // question concatination

        if (myNumber == 2 && questionTime == false)
        {
            Debug.Log("Your Number is 2 and QT is false");
        }

        //question or statement

        if (myNumber == 2 || questionTime == false)
        {
            Debug.Log("it may be that your number is 2 or it may be that question time is false");
        }

        //loops

        //while loop

        List<int> oddNumbers = new List<int>();
        int counter = 1;
        while (counter < 100)
        {
            oddNumbers.Add(counter);
            counter = counter + 2;

        }
        for(int i =0;i<oddNumbers.Count; i++)
        {
            Debug.Log("Odd Number :" + oddNumbers[i]);
        }


        // for loop statement (start value, how this ends, incrementation)
        for (int i = 0; i < fruites.Length; i = i + 1)
        {
            Debug.Log("fruit ar posistion" + i + "is" + fruites[i]);
        }

        for (int i =0; i<20; i = i +2)
        {
            evenNumbers.Add(i);
            evenNumbersSmart[i / 2] = i;
        }

        //print the list

        for(int i=0; i<evenNumbers.Count; i++) // i = i+1, i++
        {
            Debug.Log("Number is:" + evenNumbers[i]);
        }

        //add 100 numbers to a list and print the numbers that are divisible by 5
        List<int> myOneHundredNumbers = new List<int>();
        for(int i =0; i<=100; i++)
        {
            myOneHundredNumbers.Add(i);
        }

        //the smart way
        for(int i =0; i < myOneHundredNumbers.Count; i = i + 5)
        {
            Debug.Log("Numbers divisible by 5:" + myOneHundredNumbers[i]);
        }

        // the less smart way
        for (int i = 0; i <= 100; i++)
        {
            if (i % 5 == 0)
            {
                Debug.Log("Numbers divisible by 5:" + myOneHundredNumbers[i]);
            }
        }


    }

    // Update is called once per frame
    void Update () {

        
    }
}
