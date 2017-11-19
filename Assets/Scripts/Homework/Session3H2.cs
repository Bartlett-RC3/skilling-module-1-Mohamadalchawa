using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3H2 : MonoBehaviour {

	
    public void OnMouseOver()
    {

        this.transform.Rotate(Vector3.up, 270 * Time.deltaTime, Space.Self);
    }

}
