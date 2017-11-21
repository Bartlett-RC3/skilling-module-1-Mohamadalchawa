using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Session4_H : MonoBehaviour 
{
    private Dictionary<KeyCode, Vector3> _movement;
    public GameObject Sphere;
    private float speed = 5f;

    private IEnumerator _dropSpheres;

    // Use this for initialization
    private void Start()
    {
        _dropSpheres = SphereDrop();
        _movement = new Dictionary<KeyCode, Vector3>()
        {
            {KeyCode.W, Vector3.forward},
            {KeyCode.S, Vector3.back},
            {KeyCode.A, Vector3.left},
            {KeyCode.D, Vector3.right},
            {KeyCode.Space, Vector3.up}

        };

        StartCoroutine(_dropSpheres);
       


    }

    // Update is called once per frame
    void Update()
    {
        SphereMove();
        //StartCoroutine(dropSpheres);
        if (Time.time > 30)
        {
            StopCoroutine(_dropSpheres);
            StopAllCoroutines();
        }

    }

    public void SphereMove()
    {
        foreach (KeyCode direction in _movement.Keys)
        {
            if (Input.GetKey(direction))
            {
                this.transform.Translate(_movement[direction] * speed * Time.deltaTime, Space.World);
            }
        }

    }

    IEnumerator SphereDrop()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.05f);
            Vector3 spherePosition = new Vector3(Random.Range(-2f, 4f), Random.Range(3f, 5f), Random.Range(-3f, 0f));
            Quaternion rotation =
                new Quaternion(0, 0, 0, 0);
            GameObject newsphere = Instantiate(Sphere, spherePosition, rotation);

        }
    }
}
