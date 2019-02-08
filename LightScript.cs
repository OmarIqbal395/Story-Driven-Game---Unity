using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightScript : MonoBehaviour {

    public GameObject light;
    public bool on;
    public bool lightStatus;

    void OnTriggerEnter(Collider other)
    {
        on = true;
    }

    void OnTriggerExit(Collider other)
    {
        on = false;
    }

    void Update()
    {
        if(light.active == true)
        {
            lightStatus = true;
        }
        else
        {
            lightStatus = false;
        }

        if (on)
        {
            if (lightStatus)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    light.active = false;
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    light.active = true;
                }
            }
        }
    }
}
