using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Class1 : MonoBehaviour
{
     void Update()
    {
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        { SceneManager.LoadScene("SampleScene"); }

    }
}
