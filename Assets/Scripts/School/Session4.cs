using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4 : MonoBehaviour {

    //variables

    public GameObject columnPrefab;
    private IEnumerator createColumnCoroutine;


	// Use this for initialization
	void Start ()
	{
	    createColumnCoroutine = dropColumns();
        
	}
	
	// Update is called once per frame
	void Update () {
	    StartCoroutine(createColumnCoroutine);
	    if (Time.time > 3)
	    {
	        StopCoroutine(createColumnCoroutine);
            StopAllCoroutines();
	    }
    }

    // Coroutines
    IEnumerator dropColumns()
    {
        while (true)
        {
        yield return new WaitForSeconds(5);
        Vector3 columnPosition = new Vector3(Random.Range(-5f, 6f), Random.Range(8f, 10f), Random.Range(-7f, 0f));
        Quaternion columnRotation = new Quaternion(Random.Range(0, 90), Random.Range(0, 90), Random.Range(0, 90), 1);
        GameObject newColumn = Instantiate(columnPrefab, columnPosition, columnRotation);

    }
}
}

