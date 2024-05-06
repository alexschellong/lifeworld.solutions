using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CVshow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cv;
    public GameObject about;
    public GameObject bio;
    public GameObject artworks;
    public GameObject descriptions;
    public GameObject spawner;
    public GameObject contacts;
    public GameObject return_text;
    public GameObject links;
    public GameObject graphic_box;

    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController controller;




    private bool switch1;
    private bool switch2;

    private bool contactsBool;


    public GameObject myPlayer;
    private longtextAppear longtext;

    // Update is called once per frame

    private void Start()
    {
        switch1 = false;
        switch2 = false;
        contactsBool = false;

        longtext = myPlayer.GetComponent<longtextAppear>();



    }


    void Update()
    {

        if (myPlayer.transform.localRotation.x > 0.70)
        {
            switch2 = false;

            if ( contactsBool == false && switch1 == false)
            {
                cv.SetActive(true);
                (cv.GetComponent("scrollrectcustom") as MonoBehaviour).enabled = true;
                gameObject.GetComponent<spawner>().enabled = false;
                bio.SetActive(true);
                contacts.SetActive(true);
                about.SetActive(false);
                artworks.SetActive(false);
                descriptions.SetActive(false);

                longtext.enabled = false;

                switch1 = true;
               


           

            }


            if (contactsBool == false && Input.GetMouseButtonDown(0))
            {

                contactsBool = true;


                controller.m_MouseLook.lockCursor = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                controller.m_WalkSpeed = 0;
                controller.m_MouseLook.XSensitivity = 0;
                controller.m_MouseLook.YSensitivity = 0;

                bio.SetActive(false);
                contacts.SetActive(false);
                cv.SetActive(false);
                (cv.GetComponent("scrollrectcustom") as MonoBehaviour).enabled = false;


                graphic_box.SetActive(true);
                links.SetActive(true);
                return_text.SetActive(true);

            }


            else if(contactsBool == true) {



           


                if (Input.GetMouseButtonDown(1))
                {
                   

                    
                    graphic_box.SetActive(false);
                    links.SetActive(false);
                    return_text.SetActive(false);

                    controller.m_WalkSpeed = 4;
                    controller.m_MouseLook.XSensitivity = 2;
                    controller.m_MouseLook.YSensitivity = 2;
                    controller.m_MouseLook.lockCursor = true;
                    switch1 = false;

                    contactsBool = false;
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                    Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);


                }


            }


        }
        else if(myPlayer.transform.localRotation.x < 0.70)
        {

            if (switch2 == false)
            {
                (cv.GetComponent("scrollrectcustom") as MonoBehaviour).enabled = false;
                gameObject.GetComponent<spawner>().enabled = true;
                cv.SetActive(false);
                bio.SetActive(false);
                contacts.SetActive(false);
                about.SetActive(true);
                longtext.enabled = true;
                if (!spawner.GetComponent<spawner>().artwork_off)
                {
                    artworks.SetActive(true);
                    descriptions.SetActive(true);
                }
              

                switch2 = true;

            }
            switch1 = false;



        };
    }
}

