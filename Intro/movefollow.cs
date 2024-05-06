using UnityEngine;
using System.Collections;
using UnityEngine.UI.Extensions;

public class movefollow : MonoBehaviour
{
    public Transform target1, target2, target3, target4, targetY, targetX, movemove;
    public Camera cam;
    private linerenderzoomcustom line;
    public GameObject canvas;

    RectTransform canvasx;

    float calc1, calc2, calc3, calc4, calc5, calc6, calc7, calc8, calc9, calc10, calc11;


    void Start()
    {

        canvasx = canvas.GetComponent<RectTransform>();
        line = gameObject.GetComponent<linerenderzoomcustom>();


    }

    private void Update()
    {
        Vector3 screenPos1 = cam.WorldToScreenPoint(target1.position);
        Vector3 screenPos2 = cam.WorldToScreenPoint(target2.position);
        Vector3 screenPos3 = cam.WorldToScreenPoint(target3.position);
        Vector3 screenPos4 = cam.WorldToScreenPoint(target4.position);
        Vector3 screenPos5 = cam.WorldToScreenPoint(targetX.position);
        Vector3 screenPos6 = cam.WorldToScreenPoint(targetY.position);
        Vector3 screenPos7 = cam.WorldToScreenPoint(movemove.position);

        //Debug.Log("target is " + screenPos.x + " pixels from the left");
        //Debug.Log(screenPos.x);
        //Debug.Log("target is " + screenPos.y + " pixels from the left");


        calc1 = SuperLerp(0, canvasx.rect.width, 0, cam.pixelWidth, screenPos1.x);
        calc2 = SuperLerp(0, canvasx.rect.width, 0, cam.pixelWidth, screenPos1.y);


        calc3 = SuperLerp(0, canvasx.rect.width, 0, cam.pixelWidth, screenPos2.x);
        calc4 = SuperLerp(0, canvasx.rect.width, 0, cam.pixelWidth, screenPos2.y);


        calc5 = SuperLerp(0, canvasx.rect.width, 0, cam.pixelWidth, screenPos3.x);
        calc6 = SuperLerp(0, canvasx.rect.width, 0, cam.pixelWidth, screenPos3.y);


        calc7 = SuperLerp(0, canvasx.rect.width, 0, cam.pixelWidth, screenPos4.x);
        calc8 = SuperLerp(0, canvasx.rect.width, 0, cam.pixelWidth, screenPos4.y);

        calc9 = SuperLerp(0, canvasx.rect.width, 0, cam.pixelWidth, screenPos5.x);
        calc10 = SuperLerp(0, canvasx.rect.width, 0, cam.pixelWidth, screenPos6.y);

        calc11 = SuperLerp(0, canvasx.rect.width, 0, cam.pixelWidth, screenPos7.x);

        line.m_points[0].x = calc1;
        line.m_points[1].x = calc1;
        line.m_points[0].x = calc1;
        line.m_points[1].x = calc1;

        line.m_points[0].y = calc2;


        line.m_points[4].x = calc3;
        line.m_points[3].x = calc3;
        line.m_points[2].x = calc3;

        line.m_points[3].y = calc4;


        line.m_points[10].x = calc5;


        line.m_points[9].y = calc6;
        line.m_points[11].y = calc6;
        line.m_points[10].y = calc6;


        line.m_points[13].x = calc7;

        line.m_points[12].y = calc8;
        line.m_points[13].y = calc8;

        line.m_points[8].x = calc9;
        line.m_points[9].x = calc9;
        line.m_points[11].x = calc9;
        line.m_points[12].x = calc9;

        line.m_points[1].y = calc10;
        line.m_points[2].y = calc10;
        line.m_points[4].y = calc10;
        line.m_points[5].y = calc10;
        line.m_points[7].y = calc10;
        line.m_points[8].y = calc10;

        line.m_points[7].x = calc11;
        line.m_points[6].x = calc11;
        line.m_points[5].x = calc11;



        //  calc3 = SuperLerp(0, canvasx.rect.width, 0, cam.pixelWidth, screenPos.x);
        //calc4 = SuperLerp(0, canvasx.rect.height, 0, cam.pixelHeight, screenPos.y);

        // line.m_points[5].x = calc3;



        line.SetAllDirty();


    }

    private float SuperLerp(float from, float to, float from2, float to2, float value)
    {
        if (value <= from2)
            return from;
        else if (value >= to2)
            return to;
        return (to - from) * ((value - from2) / (to2 - from2)) + from;
    }
}