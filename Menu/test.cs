using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public Vector2 lol;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    public void iswheelmoving()
    {
        if (Input.GetAxis("Mouse ScrollWheel") != 0f) // forward
        {
            //lol = Input.GetAxis("mouse scrollwheel");
            //lol *= Time.deltaTime;
            //return lol;
            //Debug.Log(Input.GetAxis("Mouse ScrollWheel"));
        }

    }


    public bool iswheelmoving2()
    {
        if (Input.mouseScrollDelta.y != 0f) // forward
        {
            lol = Input.mouseScrollDelta;


            return true;

        }
        else
        {
            return false;
        }
    }

}