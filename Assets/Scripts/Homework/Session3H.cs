using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// MAIN CUBE CHANGES TO BLUE WHEN INTERACTING WITH THE ENVIRONMENT
// THE CUBE TURNS RED EVERYTIME IT HITS THE GROUND
// MOUSE OVER BOXES IN THE ENVIRONMENT WILL ROTATE THEM

public class Session3H : MonoBehaviour
{
    private float speed = 5f;
    private Dictionary<KeyCode, Vector3> movement;

    public Renderer rend;








    // Use this for initialization
    void Start ()
	{
        
        movement = new Dictionary<KeyCode, Vector3>()
	    {
            {KeyCode.W, Vector3.forward },
            {KeyCode.S,Vector3.back },
            {KeyCode.A,Vector3.left },
            {KeyCode.D,Vector3.right },
            {KeyCode.Space,Vector3.up }

	    };

	}
	
	// Update is called once per frame
	void Update () {
		CubeMove();
        //ColorChange();
	}

    public void CubeMove()
    {
        foreach (KeyCode direction in movement.Keys)
        {
            if (Input.GetKey(direction))
            {
                this.transform.Translate(movement[direction]*speed*Time.deltaTime, Space.World);
            }
        }
        
    }

    void OnCollisionEnter(Collision col)
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        if (col.gameObject.tag == "Box")
        {
           rend.material.color = Color.blue;
        }
        else
        {
            rend.material.color = Color.red;
        }
    }

    void OnCollisionExit(Collision col)
    {
        rend.material.color = Color.white;
    }
    
}
