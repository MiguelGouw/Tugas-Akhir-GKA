using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerascript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float a=0.05f;
        if(Input.GetAxis ("Mouse ScrollWheel")>0)
        {
            GetComponent<Transform>().position = new Vector3(transform.position.x,transform.position.y,transform.position.z+a);
            //transform.Rotate(-2,0,0);
        }
        if(Input.GetAxis ("Mouse ScrollWheel")<0)
        {
            GetComponent<Transform>().position = new Vector3(transform.position.x,transform.position.y,transform.position.z-a);
           // transform.Rotate(2,0,0);
        }
        if(Input.GetAxis ("Horizontal")>0)
        {
           GetComponent<Transform>().position = new Vector3(transform.position.x+a,transform.position.y,transform.position.z); 
        }
        if(Input.GetAxis ("Horizontal")<0)
        {
            GetComponent<Transform>().position = new Vector3(transform.position.x-a,transform.position.y,transform.position.z);
        }
        if(Input.GetAxis ("Vertical")>0)
        {
         GetComponent<Transform>().position = new Vector3(transform.position.x,transform.position.y+a,transform.position.z);  
        }
        if(Input.GetAxis ("Vertical")<0)
        {
            GetComponent<Transform>().position = new Vector3(transform.position.x,transform.position.y-a,transform.position.z);
        }
    }
}
