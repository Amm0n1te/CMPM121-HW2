using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPanning : MonoBehaviour
{

    public Camera pancam;
    public Camera firstcam;
    public Camera thirdcam;  //default main cam
    public Camera orthocam;
    private float increment;

    // Start is called before the first frame update
    void Start()
    {
 
        increment = 0.05f;
        thirdcam.enabled = false;
        orthocam.enabled = false;
        pancam.enabled = true;
        firstcam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Camera>().transform.Rotate(0f, 0f, increment, Space.Self);
        pancam.transform.Rotate(0f, increment, 0f, Space.Self);
        if (pancam.transform.localEulerAngles.y > 359) increment *= -1;
        else if (pancam.transform.localEulerAngles.y < 250) increment *= -1;
        Debug.Log(pancam.transform.localEulerAngles.y.ToString() + "  and " + increment.ToString());
        
    }
}
