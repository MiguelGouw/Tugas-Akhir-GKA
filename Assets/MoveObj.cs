using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObj : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cube;
    // public GameObject cube1;
    public Color blackcolor;
    void Start()
    {
        
    }
    private Animation anim;
    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKey(KeyCode.UpArrow))
        // {
        //     Vector3 boxposition = transform.position;
        //     boxposition.y += 0.1f;
        //     transform.position = boxposition;

        // }
        // if(Input.GetKey(KeyCode.DownArrow))
        // {
        //     Vector3 boxposition = transform.position;
        //     boxposition.y -= 0.1f;
        //     transform.position = boxposition
        // }
        // if(Input.GetKey(KeyCode.LeftArrow))
        // {
        //     Vector3 boxposition = transform.position;
        //     boxposition.x -= 0.1f;
        //     transform.position = boxposition;

        // }
        // if(Input.GetKey(KeyCode.RightArrow))
        // {
        //     Vector3 boxposition = transform.position;
        //     boxposition.x += 0.1f;
        //     transform.position = boxposition;

        // }
        
        // if(cube.transform.position.y == cube1.transform.position.y)
        // {
        //     cube.GetComponent<Animator>().enabled= false;
        //     Destroy(cube.gameObject);
        // }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            cube.GetComponent<Animator>().enabled= true;
        }
        
    }
    public void OnTriggerEnter(Collider other) {
       
        other.transform.GetComponent<Renderer>().material.color = blackcolor;
        
        Destroy(other.gameObject);
    }
  
    //  public void OnTriggerExit(Collider other) {
    //     other.gameObject.SetActive(true);
    //     other.GetComponent<Renderer>().enabled = true;
    // }
    
}
