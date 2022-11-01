using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //print(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        //print("Hello");

        if(Input.GetKey(KeyCode.W) == true)
        {
            //print("W");

            transform.position = new Vector3(transform.position.x, transform.position.y + 0.01f, 0);
        }

        if (Input.GetKey(KeyCode.S) == true)
        { 
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.01f, 0);
        }

        if (Input.GetKey(KeyCode.A) == true)
        {
            transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y, 0);
        }

        if (Input.GetKey(KeyCode.D) == true)
        {
            transform.position = new Vector3(transform.position.x + 0.01f, transform.position.y, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.01f, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.01f, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            transform.position = new Vector3(transform.position.x + 0.01f, transform.position.y, 0);
        }
    }
}
