using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class longtextAppear : MonoBehaviour
{
   
    public GameObject description_text;
    public GameObject description_long_text;

    public bool longText_active = false;
    public GameObject longText_obj;
    private ListPositionCtrl listCtrl;
    private ListPositionCtrl2 listCtrl2;
    public spawner spawn;
    public GameObject myPlayer;

    public GameObject artwork_titles;
    public GameObject artwork_descriptions;
    public GameObject ScrollArea;

    private delegate void ScrollHandlerDelegate(Vector2 scrollDelta);//tady


    public  test _test;
    private RectTransform ScrollAreaRect;

    private bool down = false;
    private bool up = false;




    // Update is called once per frame

    private void Start()
    {
       
        listCtrl = artwork_titles.GetComponent<ListPositionCtrl>();

        listCtrl2 = artwork_descriptions.GetComponent<ListPositionCtrl2>();

        ScrollAreaRect = ScrollArea.GetComponent<RectTransform>();






    }

  
    public void  artwork_changed()
    {


     




        if (spawn.whatToSpawnPrefab[spawn.contentID] == longText_obj && longText_active == false)
        {


       
            description_text.SetActive(false);
            description_long_text.SetActive(true);
            

            longText_active = true;




        }
        




    }

    public void OnScroll(bool arg)
    {
        if (arg == true )
        {
            ScrollDeltaHandler(_test.lol);
            
        }
    }


    void ScrollDeltaHandler(Vector2 mouseScrollDelta)
    {
        
        

        artwork_changed();


        if (longText_active == true) {

           

            if (mouseScrollDelta.y < 0 && ScrollAreaRect.anchoredPosition.y + 32 > 619.5)
            {
                if (down == true) {

                    longText_active = false;
                    description_text.SetActive(true);
                    description_long_text.SetActive(false);

                    listCtrl2.MoveOneUnitUp();
                    listCtrl.MoveOneUnitUp();
                    spawn.spawnUp();
                    down = false;

                }
                else {
                    down = true;
                }

            }



            else if (mouseScrollDelta.y > 0 && ScrollAreaRect.anchoredPosition.y - 32 < 0.5 )
            {
                if (up == true)
                {

                    longText_active = false;
                    description_text.SetActive(true);
                    description_long_text.SetActive(false);

                    listCtrl2.MoveOneUnitDown();
                    listCtrl.MoveOneUnitDown();
                    spawn.spawnDown();
                    up = false;

                }
                else
                {
                    up = true;
                }
            }

        }
       
        
    }


    public void Update()
    {
       
            OnScroll(_test.iswheelmoving2());
        

    }
}
