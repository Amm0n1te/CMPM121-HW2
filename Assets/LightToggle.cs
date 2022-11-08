using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightToggle : MonoBehaviour
{
    Light thisLight;
    private int controller = 3;
    private float savedIntensity;

    // Start is called before the first frame update
    void Start()
    {
        thisLight = GetComponent<Light>();
        savedIntensity = thisLight.intensity;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)) {
            if (controller == 3) {
                controller = 2;
                thisLight.intensity = savedIntensity/3;
            }
            else if (controller == 2) {
                controller = 1;
                thisLight.intensity = 0;
            }
            else if (controller == 1) {
                controller = 3;
                thisLight.intensity = savedIntensity;
            }
        }
        
    }
}
