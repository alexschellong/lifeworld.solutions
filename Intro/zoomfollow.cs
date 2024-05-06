using UnityEngine;
using System.Collections;
using UnityEngine.UI.Extensions;

public class zoomfollow : MonoBehaviour
{
    public Transform target;
    public Transform target2;
    public Camera cam;
    public linerenderzoomcustom line;
    public GameObject canvas;

    RectTransform canvasx;

    [HideInInspector]
    public float calc1,calc2,calc3,calc4;


    void Start()
    {

        canvasx = canvas.GetComponent<RectTransform>();
   

    }

    private void Update()
    {
        Vector3 screenPos = cam.WorldToScreenPoint(target.position);
        Vector3 screenPos2 = cam.WorldToScreenPoint(target2.position);
        //Debug.Log("target is " + screenPos.x + " pixels from the left");
        //Debug.Log(screenPos.x);
        //Debug.Log("target is " + screenPos.y + " pixels from the left");


        calc1 = SuperLerp(0, canvasx.rect.width, 0, cam.pixelWidth, screenPos2.x);

        line.m_points[0].x = calc1;
        line.m_points[1].x = calc1;


       


           calc3 = SuperLerp(0, canvasx.rect.width, 0, cam.pixelWidth, screenPos.x );
        calc4  = SuperLerp(0, canvasx.rect.height, 0, cam.pixelHeight, screenPos.y );

        line.m_points[5].x = calc3;
       line.m_points[5].x = calc3;
        line.Points[6].x = calc3;
        line.Points[6].y = calc4;

        calc2 = canvasx.rect.width / 2;

        line.m_points[2].x = calc2;
           line.m_points[3].x = calc2;
        line.m_points[4].x = calc2;


       

        line.SetAllDirty();


    }

    private float SuperLerp(float from ,float to , float from2 ,float  to2 , float value )
    {
        if (value <= from2)
            return from;
        else if (value >= to2)
            return to;
        return (to - from) * ((value - from2) / (to2 - from2)) + from;
    }
}