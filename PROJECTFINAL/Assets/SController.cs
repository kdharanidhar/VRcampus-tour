using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SController : MonoBehaviour
{

    void Update()
    {
        transform.rotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTrackedRemote);
        
    }
}
