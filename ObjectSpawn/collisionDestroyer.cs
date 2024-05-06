using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDestroyer : MonoBehaviour
{


    public int ID;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "artwork")
        {
            if (ID < collision.gameObject.GetComponent<collisionDestroyer>().ID)
            {


                Destroy(gameObject);
            }

        }
    }



}
