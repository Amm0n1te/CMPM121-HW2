using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPanning : MonoBehaviour
{

    public Camera instrcam;
    public Camera thirdcam;  //default main cam
    public Camera firstcam;
    public Camera pancam;
    public Camera orthocam;
    private float increment;
    private int camIndex = 1;

    // Start is called before the first frame update
    void Start()
    {
 
        increment = 0.05f;
        instrcam.enabled = true;
        thirdcam.enabled = false;
        firstcam.enabled = false;
        pancam.enabled = false;
        orthocam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Camera>().transform.Rotate(0f, 0f, increment, Space.Self);
        pancam.transform.Rotate(0f, increment, 0f, Space.Self);
        if (pancam.transform.localEulerAngles.y > 359) increment *= -1;
        else if (pancam.transform.localEulerAngles.y < 250) increment *= -1;
        //Debug.Log(pancam.transform.localEulerAngles.y.ToString() + "  and " + increment.ToString());

        if (Input.GetKeyDown(KeyCode.Space)) {
            camIndex++;
            if (camIndex > 5) camIndex = 1;
            if (camIndex == 1) {
                orthocam.enabled = false;
                instrcam.enabled = true;
            }
            if (camIndex == 2) {
                instrcam.enabled = false;
                thirdcam.enabled = true;
            }
            else if (camIndex == 3) {
                thirdcam.enabled = false;
                firstcam.enabled = true;
            }
            else if (camIndex == 4) {
                firstcam.enabled = false;
                pancam.enabled = true;
            }
            else if (camIndex == 5) {
                pancam.enabled = false;
                orthocam.enabled = true;
            }
        }
        
    }
}
