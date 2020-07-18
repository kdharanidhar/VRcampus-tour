using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Class2 : MonoBehaviour
{
    private RaycastHit vision;
    public float rayLength;
    public bool select14, select13, select12, select11, select10, select9, select8, select7, select6, select5, select4, select3, select2, select1;

    // Start is called before the first frame update
    void Start()
    {
        
        rayLength = 10.0f;

    }
    //public float speed;

    // Update is called once per frame
    void FixedUpdate()
    {
        select1 = false;
        select2 = false;
        select3 = false;
        select4 = false;
        select5 = false;
        select6 = false;
        select7 = false;
        select8 = false;
        select9 = false;
        select10 = false;
        select11 = false;
        select12 = false;
        select13 = false;
        select14 = false;
       
        Debug.DrawRay(transform.position, transform.forward * rayLength, Color.blue, 0.5f);

        if (Physics.Raycast(transform.position, transform.forward, out vision, 300))
        {
           
            if (vision.collider.tag == "Reset")
            {
                select1 = true;
            }
            if (vision.collider.tag == "VKJ")
            {
                select2 = true;

            }
            if (vision.collider.tag == "VV")
            {
                select3 = true;

            }
            if (vision.collider.tag == "JVC")
            {
                select4 = true;

            }
            if (vision.collider.tag == "Library")
            {
                select5 = true;

            }
            if (vision.collider.tag == "Chith Vihar")
            {
                select6 = true;

            }
            if (vision.collider.tag == "Tifac")
            {
                select7 = true;

            }
            if (vision.collider.tag == "Indoor")
            {
                select8 = true;
            }
            if (vision.collider.tag == "Ground")
            {
                select9 = true;

            }
            if (vision.collider.tag == "Football Court")
            {
                select10 = true;

            }
            if (vision.collider.tag == "Handball Court")
            {
                select11 = true;

            }
            if (vision.collider.tag == "Basketball court")
            {
                select12 = true;

            }
            if (vision.collider.tag == "Volleyball court")
            {
                select13 = true;

            }
        }


        if (select1 == true)
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
            { SceneManager.LoadScene("SampleScene"); }

        }
        if (select2 == true)
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
            { SceneManager.LoadScene("VKJ"); }
        }
        if (select3 == true)
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
            { SceneManager.LoadScene("VV"); }
        }
        if (select4 == true)
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
            { SceneManager.LoadScene("JVC"); }
        }
        if (select5 == true)
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
            { SceneManager.LoadScene("Library"); }
        }
        if (select6 == true)
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))

            { SceneManager.LoadScene("Chith Vihar"); }
        }
        if (select7 == true)
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))

            { SceneManager.LoadScene("Tifac"); }
        }
        if (select8 == true)
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))

            { SceneManager.LoadScene("Indoor"); }
        }
        if (select9 == true)
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))

            { SceneManager.LoadScene("Ground"); }
        }
        if (select10 == true)
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))

            { SceneManager.LoadScene("Football Court"); }
        }
        if (select11 == true)
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
            { SceneManager.LoadScene("Handball Court"); }
        }
        if (select12 == true)
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
            { SceneManager.LoadScene("Basketball Court"); }
        }
        if (select13 == true)
        { 
            if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
            {  SceneManager.LoadScene("Volleyball Court");
        }
                }
                   
        


    }
}

