using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//HOMEWORK 2 TEST COMMIT 3 

public class CameraPanning : MonoBehaviour
{

    public Camera instrcam;
    public Camera instrcam2;
    public Camera thirdcam;  //default main cam
    public Camera firstcam;
    public Camera pancam;
    public Camera particlescam;
    public Camera orthocam;
    private float increment;
    private int camIndex = 1;

    // Start is called before the first frame update
    void Start()
    {
 
        increment = 0.05f;
        instrcam.enabled = true;
        instrcam2.enabled = false;
        thirdcam.enabled = false;
        firstcam.enabled = false;
        pancam.enabled = false;
        particlescam.enabled = false;
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
            if (camIndex > 7) camIndex = 1;
            if (camIndex == 1) {
                orthocam.enabled = false;
                instrcam.enabled = true;
            }
            if (camIndex == 2) {
                instrcam.enabled = false;
                instrcam2.enabled = true;
            }
            if (camIndex == 3) {
                instrcam2.enabled = false;
                thirdcam.enabled = true;
            }
            else if (camIndex == 4) {
                thirdcam.enabled = false;
                firstcam.enabled = true;
            }
            else if (camIndex == 5) {
                firstcam.enabled = false;
                pancam.enabled = true;
            }
            else if (camIndex == 6) {
                pancam.enabled = false;
                particlescam.enabled = true;
            }
            else if (camIndex == 7) {
                particlescam.enabled = false;
                orthocam.enabled = true;
            }
        }
        
    }
}
