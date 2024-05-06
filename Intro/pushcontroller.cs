using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushcontroller : MonoBehaviour
{

    Animator animator;
    int isWpressedhash;
    int isApressedhash;
    int isSpressedhash;
    int isDpressedhash;
    int isEpressedhash;
    int iskeypressedhash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWpressedhash = Animator.StringToHash("w_pressed");
      
        isApressedhash = Animator.StringToHash("a_pressed");
        isSpressedhash = Animator.StringToHash("s_pressed");
        isDpressedhash = Animator.StringToHash("d_pressed");
        isEpressedhash = Animator.StringToHash("e_pressed");
        iskeypressedhash = Animator.StringToHash("key_pressed");

    }

    // Update is called once per frame
    void Update()
    {
        bool isKeypressed = animator.GetBool(iskeypressedhash);

        bool isWpressed = animator.GetBool(isWpressedhash);
        bool wpressing = Input.GetKey("w");

        bool isApressed = animator.GetBool(isApressedhash);
        bool apressing = Input.GetKey("a");

        bool isSpressed = animator.GetBool(isSpressedhash);
        bool spressing = Input.GetKey("s");

        bool isDpressed = animator.GetBool(isDpressedhash);
        bool dpressing = Input.GetKey("d");

        bool isEpressed = animator.GetBool(isEpressedhash);
        bool epressing = Input.GetKey("e");

        

        if (isKeypressed == false)
        { 
        if (wpressing || apressing || spressing || dpressing || epressing)
                {
                animator.SetBool(iskeypressedhash, true);
            }
        }

        if (!isWpressed && wpressing)
        {
            animator.SetBool(isWpressedhash,true);
        }

          if (isWpressed && !wpressing)
        {
            animator.SetBool(isWpressedhash, false);
        }

        if (!isApressed && apressing)
        {
            animator.SetBool(isApressedhash, true);
        }

        if (isApressed && !apressing)
        {
            animator.SetBool(isApressedhash, false);
        }

        if (!isSpressed && spressing)
        {
            animator.SetBool(isSpressedhash, true);
        }

        if (isSpressed && !spressing)
        {
            animator.SetBool(isSpressedhash, false);
        }

        if (!isDpressed && dpressing)
        {
            animator.SetBool(isDpressedhash, true);
        }

        if (isDpressed && !dpressing)
        {
            animator.SetBool(isDpressedhash, false);
        }

        if (!isEpressed && epressing)
        {
            animator.SetBool(isEpressedhash, true);
        }

        if (isEpressed && !epressing)
        {
            animator.SetBool(isEpressedhash, false);
        }
    }
}
