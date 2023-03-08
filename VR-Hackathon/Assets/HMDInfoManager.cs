using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMDInfoManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Is device active" + XRSettings.isDeviceActive);
        Debug.Log("Device name is " + XRSettings.loadedDeviceName);
        if (!XRSettings.isDeviceActive)
        {
            Debug.Log("No headset detected");
        }
        else if(XRSettings.isDeviceActive && (XRSettings.loadedDeviceName == "Mock HMD" || XRSettings.loadedDeviceName == "MockHMD Display")) 
        {
            Debug.Log("using Mock HMD");
        }
        else
        {
            Debug.Log("using a " + XRSettings.loadedDeviceName + " headset");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
