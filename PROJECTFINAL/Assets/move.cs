using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    private RaycastHit vision;
    public float rayLength;
    public bool isGrabbed;
    public GameObject option;
    
    // Start is called before the first frame update
    void Start()
    {
        isGrabbed = false;
        rayLength = 4.0f;

    }
public float speed;
public int var0,var1,var2;

public Transform target1,target2,target3,target4;
    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position,transform.forward*rayLength,Color.blue,0.5f);

        if (Physics.Raycast(transform.position, transform.forward, out vision, Mathf.Infinity))
        {
            Debug.Log(vision.collider.name);
            if (vision.collider.tag == "Football Court")
            { if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
                { SceneManager.LoadScene("Football Court"); }
                    }
            if (vision.collider.tag == "BasketBall Court")
            {
                if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
                { SceneManager.LoadScene("Basketball Court"); }

            }
            if (vision.collider.tag == "Tennis Court")
            {
                if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
                { SceneManager.LoadScene("Tennis Court"); }
            }
            if (vision.collider.tag == "Volleyball Court")
            {
                if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
                { SceneManager.LoadScene("Volleyball Court"); }
            }
            if (vision.collider.tag == "Handball Court")
            {
                if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
                { SceneManager.LoadScene("Handball Court"); }
            }
            if (vision.collider.tag == "Indoor Stadium")
            {
                if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
                { SceneManager.LoadScene("Indoor Stadium"); }
            }
        }  
                    
                
		float step = speed * Time.deltaTime;
		if(var0==0)
		{
		transform.position = Vector3.MoveTowards(transform.position, target1.position, step);}
		 if(target1.position==transform.position)
		 {var0++;transform.Rotate(0,-90,0);}
	 if(var0>0&&var1==0&&var2==0)
		 { transform.position = Vector3.MoveTowards(transform.position, target2.position, step/2);}
	 if(target2.position==transform.position)
		 {var1++;transform.Rotate(0,-90,0);}
	 if(var1>0&&var2==0)
	 {transform.position = Vector3.MoveTowards(transform.position, target3.position, step);}
  if(target3.position==transform.position)
		 {var2++;transform.Rotate(0,-90,0);}
	 if(var2>0)
		 {transform.position = Vector3.MoveTowards(transform.position, target4.position, step);}
    }
}