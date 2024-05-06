using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class spawner : MonoBehaviour
{
    public Transform spawnLocation;
    public Transform floor;
    public GameObject[] whatToSpawnPrefab;

    public GameObject description_text;
    public GameObject artworks_text;
    public GameObject myPlayer;
    public ListPositionCtrl list;
    int count = 0;
    public int contentID = 0;
    int contentIDSize;
    public longtextAppear longtext;



    public bool artwork_off;
    private bool no_spawn;



    private void Start()
    {
        spawnSomething();

        contentIDSize = whatToSpawnPrefab.Length - 1;



    }


    public void spawnSomething()
    {

        int contentID = list.GetCenteredContentID();


        GameObject x = Instantiate(whatToSpawnPrefab[contentID], new Vector3(spawnLocation.transform.position.x, floor.transform.position.y, spawnLocation.transform.position.z), Quaternion.Euler(0, myPlayer.transform.eulerAngles.y, 0)) as GameObject;
        //Debug.Log(myPlayer.transform.eulerAngles.y);
        collisionDestroyer p = x.GetComponent<collisionDestroyer>();
        p.ID = count;
        count = count + 1;



        no_spawn = false;
    }


    public void spawnUp()
    {
        if (contentID == contentIDSize)
        { contentID = 0; }
        else
        {
            contentID = contentID + 1;
        }
        GameObject x = Instantiate(whatToSpawnPrefab[contentID], new Vector3(spawnLocation.transform.position.x, floor.transform.position.y, spawnLocation.transform.position.z), Quaternion.Euler(0, myPlayer.transform.eulerAngles.y, 0)) as GameObject;
        //Debug.Log(myPlayer.transform.eulerAngles.y);
        collisionDestroyer p = x.GetComponent<collisionDestroyer>();
        p.ID = count;
        count = count + 1;



        no_spawn = false;
    }

    public void spawnDown()
    {
        if (contentID == 0)
        {
            contentID = contentIDSize;
        }
        else
        {
            contentID = contentID - 1;
        }
        GameObject x = Instantiate(whatToSpawnPrefab[contentID], new Vector3(spawnLocation.transform.position.x, floor.transform.position.y, spawnLocation.transform.position.z), Quaternion.Euler(0, myPlayer.transform.eulerAngles.y, 0)) as GameObject;
        //Debug.Log(myPlayer.transform.eulerAngles.y);
        collisionDestroyer p = x.GetComponent<collisionDestroyer>();
        p.ID = count;
        count = count + 1;



        no_spawn = false;
    }


    void Update()
    {
        /* if(Input.GetMouseButtonDown(0) && no_spawn == false)
           {
               spawnSomething();
           }
        */
        if (Input.GetMouseButtonDown(1))
        {

            if (no_spawn == false)
            {
                no_spawn = true;

            }
            else { no_spawn = false; }


            if (longtext.enabled == false)
            {

                longtext.enabled = true;

            }
            else
            {


                longtext.enabled = false;


            }



            if (description_text.activeSelf == false)
            {
                description_text.SetActive(true);

            }

            else
            {
                description_text.SetActive(false);
            }




            if (artworks_text.activeSelf == false)
            {
                artworks_text.SetActive(true);
                artwork_off = false;
            }
            else
            {

                artworks_text.SetActive(false);
                artwork_off = true;
            }








        }
    }
}
