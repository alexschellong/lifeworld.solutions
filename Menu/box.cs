using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI.Extensions;
using System.Linq;

public class box : MonoBehaviour
{


    public Camera cam;
    public linerenderzoomcustom line;
    public GameObject canvas;

    float box_width;
    float box_height;
    float transf1, transf2;
    float max;

    RectTransform canvasx;
    // Start is called before the first frame update
    void Start()
    {
        canvasx = canvas.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        transf1 = SuperLerp(0, 1920, 0, canvasx.rect.width, 80);
        transf2 = SuperLerp(0, 1080, 0, canvasx.rect.height, 80);

        float[] maxArray = { transf1, transf2 };
        max = maxArray.Max();

        box_width = canvasx.rect.width / 2 - max;
        box_height = canvasx.rect.height / 2 - max;


        line.m_points[0].x = -(box_width);
        line.m_points[0].y = -(box_height);

        line.m_points[1].x = -(box_width);
        line.m_points[1].y = (box_height);

        line.m_points[2].x = (box_width);
        line.m_points[2].y = (box_height);

        line.m_points[3].x = (box_width);
        line.m_points[3].y = -(box_height);

        line.m_points[4].x = -(box_width);
        line.m_points[4].y = -(box_height);

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
