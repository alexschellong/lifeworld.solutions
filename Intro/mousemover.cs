using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousemover : MonoBehaviour
{

    public GameObject mouse;
    //Vector2 cursorPos;
    float posx;
    float posy;
    float sensitivity = 0.05f;
    bool first = false;


    Animator animator;
    int endpressedHash;
    int leftRandHash;
    int rightRandHash;
    int middleRandHash;

    //public float tRemain;

    Vector2 cursorTravel;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        endpressedHash = Animator.StringToHash("end");

        leftRandHash = Animator.StringToHash("left_random");
        rightRandHash = Animator.StringToHash("right_random");
        middleRandHash = Animator.StringToHash("wheel_random");

        StartCoroutine(timer_left());
        StartCoroutine(timer_right());
        StartCoroutine(timer_middle());



    }

    // Update is called once per frame
    void Update()
    {



        if (first == false)
        {
            posx = Input.GetAxis("Mouse X");
            posy = Input.GetAxis("Mouse Y");




            if (posy != 0 || posx != 0 || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(2))
            {

                animator.SetBool(endpressedHash, true);
                first = true;
                mouse.GetComponent<Animator>().enabled = false;
            }






        }
        else
        {


            //Debug.Log(mouse.transform.localPosition);
            posx = mouse.transform.localPosition[0] + Input.GetAxis("Mouse X") * sensitivity;
            posy = mouse.transform.localPosition[2] + Input.GetAxis("Mouse Y") * sensitivity;
            if (posx > -1.55)
            {
                posx = -1.55f;
            }
            if (posx < -2.4)
            {
                posx = -2.4f;
            }

            if (posy > 1.2)
            {
                posy = 1.2f;
            }
            if (posy < -0.85)
            {
                posy = -0.85f;
            }
            mouse.transform.localPosition = new Vector3(posx, 0, posy);
        }
    }


    IEnumerator timer_left()
    {

        while (true)
        {
            float tRemain = Random.Range(0, 10);
            animator.SetBool(leftRandHash, true);
            yield return new WaitForSeconds(0.1f);
            animator.SetBool(leftRandHash, false);

            yield return new WaitForSeconds(tRemain);




        }

    }

    IEnumerator timer_right()
    {

        while (true)
        {
            float tRemain = Random.Range(0, 10);
            animator.SetBool(rightRandHash, true);
            yield return new WaitForSeconds(0.1f);
            animator.SetBool(rightRandHash, false);
            yield return new WaitForSeconds(tRemain);
        }
    }

    IEnumerator timer_middle()
    {

        while (true)
        {
            float tRemain = Random.Range(0, 10);
            animator.SetBool(middleRandHash, true);
            yield return new WaitForSeconds(0.1f);
            animator.SetBool(middleRandHash, false);
            yield return new WaitForSeconds(tRemain);
        }
    }


}
