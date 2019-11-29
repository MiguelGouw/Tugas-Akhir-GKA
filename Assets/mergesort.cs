using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class mergesort : MonoBehaviour
{
    //public  GameObject sphere1;

    // Start is called before the first frame update
    int NumberOfSphere=10;
    //public int CubeHeightMax = 10;
    public GameObject[] Spheres;
    
    public void Start()
    {
       
       //int[] data[i] =new Int[UnityEngine.Random.Range(1, 10)];
      // randomNumber =  UnityEngine.Random.Range[1,10];
      int[] randomNumber = new int[10]
        {
            7,2,8,5,4,6,3,10,15,12
        }; 
         InitializeCube(randomNumber);
         StartCoroutine(MergeSort(Spheres, randomNumber, 0, Spheres.Length-1)); 
    }
    void printCube(GameObject[] Cubes)
    {
        for(int i = 0; i< Cubes.Length;i++)
        {
            print(Cubes[i].transform.localPosition.x);
        }
    }
    void InitializeCube(int[] randomNumber)
    {
        Spheres = new GameObject[NumberOfSphere];
         
       
        
        for(int i = 0; i< NumberOfSphere; i++)
        {
            
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
           
            sphere.transform.localScale = new Vector3(1f, 1f, 1);
                    //sphere.transform.localScale = new Vector3(1f, ra, 1);
            sphere.transform.position = new Vector3(i, randomNumber[i], 1);
            Debug.Log("posisi sphere: "+sphere.transform.position.x);
            sphere.transform.parent = this.transform;
           GameObject childObj = new GameObject();
            childObj.transform.parent = sphere.transform;
             
         TextMesh sphereText = childObj.AddComponent<TextMesh>();
            
         
            sphereText.text = randomNumber[i].ToString();
           sphereText.characterSize = 1;
            sphereText.fontSize = 8;
            sphereText.fontStyle = FontStyle.Bold;
            sphereText.anchor = TextAnchor.MiddleCenter;
            sphereText.color = Color.red;
            sphereText.alignment = TextAlignment.Center;
            sphereText.transform.position = new Vector3(sphere.transform.position.x,sphere.transform.position.y,sphere.transform.position.z);
            Spheres[i] = sphere;
            

            
        }
        
     //transform.position = new Vector3(-NumberOfCubes / 2f, -NumberOfCubes / 2.0f, 0);
    }
    
    IEnumerator merge(GameObject[] input,int[] randomNumber, int l, int m, int r)
    {
       
         
 //stores the starting position of both parts in temporary variables.
        // int p = l ,q = m+1;
        
        // Debug.Log("nilai p: "+ p);
        //  Debug.Log("posisi input : "+input[0].transform.position.x);
        // Vector3[] Arr= new Vector3[r-l+1] ;
        // int k=0;

        // for(int i = l ;i <= r ;i++) {
        //     if(p > m)
        //     {
        //           Arr[k++] = input[q++].transform.localPosition ;
        //          angkaleft[i] = randomNumber[l+i];
        //         Debug.Log("nilai arr kiri: "+Arr[k].y);
        //     }     
          
        // else if ( q > r)
        // {
        //     Arr[k++] = input[p++].transform.localPosition;
        //     Debug.Log("nilai arr kanan: "+Arr[k].y);
        // }   //checks if second part comes to an end or not
            

        // else if( input[p].transform.localPosition.y < input[q].transform.localPosition.y)
        // {
            
        //     Arr[k++] = input[p++].transform.localPosition;
            
        //     Debug.Log("posisi Arr : "+Arr[k].x);
        //     Debug.Log("nilai arr kiri1: "+Arr[k].y);
        // }     //checks which part ha s smaller element.
        // else
        // {
        //     Arr[k++] = input[q++].transform.localPosition ;
        //     Debug.Log("nilai arr kanan1: "+Arr[k].y);
        // }
            
        // }
        // for ( p=0 ; p< k ;p ++) {
        // /* Now the real array has elements in sorted manner including both 
        //         parts.*/
        //         if(input [l].transform.localPosition.y == Arr[p].y)
        //         {
        //             l ++;
        //         }
        //         else
        //         {
        //              input[l++].transform.localPosition = new Vector3(p,Arr[p].y,Arr[p].z) ;  
        //              Debug.Log("posisi y arr[p]"+Arr[p].y);
        //         }
                                   
        // }
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;
            
           GameObject[] left = new GameObject[n1];
             GameObject[] right = new  GameObject[n2];
           Vector3[] leftpos = new Vector3[n1];
           Vector3[] rightpos= new Vector3[n2];;
            int[] angkaleft = new int[n1];
            int[] angkaright = new int[n2];
            for (i = 0; i < n1; i++)
            {
                 yield return new WaitForSeconds(2.0f);
                left[i] = input[l + i];
                angkaleft[i] = randomNumber[l+i];
                // input[i].transform.localPosition = new Vector3(angkaleft[i],-1.15f, 1);
                 leftpos[i] =  input[l + i].transform.localPosition;
                 Debug.Log("besar left: "+angkaleft[i]);

            }

            for (j = 0; j < n2; j++)
            {
                yield return new WaitForSeconds(2.0f);
                right[j] = input[m + 1 + j];
                 angkaright[j] = randomNumber[m+1+j];
                rightpos[j] = input[m+1+j].transform.localPosition;
                // input[j].transform.localPosition = new Vector3(angkaright[j],-1.15f, 1);
                  Debug.Log("besar right: "+angkaright[j]);
               
              
            }
      

            i = 0;
            j = 0;
            k = l;
            while (i < n1 && j < n2) 
            { 
                Debug.Log("nilai n1 "+n1);
                Debug.Log("nilai n2 "+n2);
                if (left[i].transform.localPosition.y <= right[j].transform.localPosition.y) 
                { 
                     yield return new WaitForSeconds(2.0f);
                   // Debug.Log("nilai input left transform position: "+left[i].transform.localPosition.x);
                    //input[k].transform.localPosition = new Vector3(left[i].transform.localPosition.x,left[i].transform.localPosition.y, left[i].transform.localPosition.z); 
                    input[k] = left[i];
                    // randomNumber[k] = angkaleft[i];
                    //   input[k].transform.localPosition = new Vector3(k,randomNumber[k], 1);
                      //input[k].transform.localPosition = new Vector3(k,left[i].transform.localPosition.y,1);
                      LeanTween.moveLocalX(input[k],k,1);
                      LeanTween.moveLocalZ(input[k],1,.5f).setLoopPingPong(1);
                      LeanTween.moveLocalY(input[k],left[i].transform.localPosition.y,1).setLoopPingPong();
                      LeanTween.color(input[k],Color.green,1f);
            
                    
                   
                     // sphereText.transform.localPosition = new Vector3(k,randomNumber[k], 1);
                     
                    Debug.Log("nilai input kleft: "+k+" transform position: "+angkaleft[i]);
                   // Debug.Log("nilai input k: "+k+" transform scale: "+input[k].transform.localPosition.x);

                    i++; 
                    yield return new WaitForSeconds(2.0f);
                } 
                else
                { 
                     yield return new WaitForSeconds(2.0f);
                   // Debug.Log("nilai input right transform position: "+right[j].transform.localPosition.x);
                    //  input[k].transform.localPosition = new Vector3(right[j].transform.localPosition.x,right[j].transform.localPosition.y, right[j].transform.localPosition.z); 
                    //input[k].transform.localPosition =  new Vector3(angkaright[j],rightpos[j].y,rightpos[j].z);
                    
                      input[k] = right[j];
                    // randomNumber[k] = angkaright[j];
                    //   input[k].transform.localPosition = new Vector3(k,randomNumber[k], 1);
                      //input[k].transform.localPosition = new Vector3(k,right[j].transform.localPosition.y,1);
                     LeanTween.moveLocalX(input[k],k,1);
                      LeanTween.moveLocalZ(input[k],1,.5f).setLoopPingPong(1);
                      LeanTween.moveLocalY(input[k],right[j].transform.localPosition.y,1).setLoopPingPong();
                      LeanTween.color(input[k],Color.yellow,1f);
                     
                    
                  
                    
            
                     //  sphereText.transform.localPosition = new Vector3(k,randomNumber[k], 1);
                       
                    Debug.Log("nilai input kright: "+k+" nilai "+angkaright[j]);
                   
                   // Debug.Log("nilai input k: "+k+" transform position: "+input[k].transform.localPosition.x);
                    j++; 
                    yield return new WaitForSeconds(2.0f);
                } 
                k++; 
                yield return new WaitForSeconds(2.0f);
            } 
            Debug.Log("nilai j : "+ j);
            while (i < n1) 
            { 
                 yield return new WaitForSeconds(2.0f);
                Debug.Log("nilai n1 satu "+n1);
                Debug.Log("nilai n2 satu"+n2);
                //Debug.Log("nilai input left transform position: "+left[i].transform.localPosition.x);
                // input[k].transform.localPosition = new Vector3(left[i].transform.localPosition.x,left[i].transform.localPosition.y, left[i].transform.localPosition.z); 
                //input[k].transform.localPosition = new Vector3(angkaleft[i],leftpos[i].y,leftpos[i].z);
                 input[k] = left[i];
                    // randomNumber[k] = angkaleft[i];
                    //   input[k].transform.localPosition = new Vector3(k,randomNumber[k], 1);
                     // input[k].transform.localPosition = new Vector3(k,left[i].transform.localPosition.y,1);
                     LeanTween.moveLocalX(input[k],k,1);
                      LeanTween.moveLocalZ(input[k],1,.5f).setLoopPingPong(1);
                      LeanTween.moveLocalY(input[k],left[i].transform.localPosition.y,1).setLoopPingPong();
                     LeanTween.color(input[k],Color.green,1f);
                    
                  //  sphereText.transform.localPosition = new Vector3(k,randomNumber[k], 1);
                      
                  Debug.Log("nilai input kleft1: "+k+"nilai : "+angkaleft[i]);
                    //Debug.Log("nilai input k: "+k+" transform scale: "+input[k].transform.localPosition.x);
                i++; 
                k++; 
                yield return new WaitForSeconds(2.0f);
            } 
               
             while (j < n2) 
            { 
                 yield return new WaitForSeconds(2.0f);
                 Debug.Log("nilai n1 dua "+n1);
                Debug.Log("nilai n2 dua"+n2);
               // Debug.Log("nilai input right1 transform position: "+right[j].transform.localPosition.x);
                // input[k].transform.localPosition = new Vector3(right[j].transform.localPosition.x,right[j].transform.localPosition.y, right[j].transform.localPosition.z); 
                // input[k].transform.localPosition =  new Vector3(angkaright[j],rightpos[j].y,rightpos[j].z);
                    input[k] = right[j];
                    // randomNumber[k] = angkaright[j];
                    //   input[k].transform.localPosition = new Vector3(k,randomNumber[k], 1);
                    //  input[k].transform.localPosition = new Vector3(k,right[j].transform.localPosition.y,1);
                        LeanTween.moveLocalX(input[k],k,1);
                      LeanTween.moveLocalZ(input[k],1,.5f).setLoopPingPong(1);
                      LeanTween.moveLocalY(input[k],right[j].transform.localPosition.y,1).setLoopPingPong();
                       LeanTween.color(input[k],Color.yellow,1f);
                   //  sphereText.transform.position = new Vector3(k,randomNumber[k], 1);
                      //    sphereText.transform.localPosition = new Vector3(k,randomNumber[k], 1);
                       
                  Debug.Log("nilai input kright1: "+k+" nilai : "+angkaright[j]);
                   
                    //Debug.Log("nilai input k: "+k+" transform position: "+input[k].transform.localPosition.x);
                j++; 
                k++; 
                yield return new WaitForSeconds(2.0f);
            } 
            for(i=r;i>=l;i--)
            {
              yield return new WaitForSeconds(2.0f);
                k--;
                 
                  input[i] = input[k];
                     LeanTween.moveLocalX(input[i],1,.5f);
                      LeanTween.moveLocalZ(input[i],1,.5f).setLoopPingPong(1);
                      LeanTween.moveLocalY(input[i],input[k].transform.localPosition.y,1);
                      LeanTween.color(input[i],Color.white,1f);
                      //input[i].transform.localPosition = new Vector3(input[k].transform.localPosition.xs,input[k].transform.localPosition.y,1);
            }
          
           
         yield return new WaitForSeconds(2.0f);
        
    }
        
           
    IEnumerator MergeSort(GameObject[] unsortedList, int[] randomNumber, int l, int r )
    {
        yield return new WaitForSeconds(2.0f);
       Debug.Log("nilai l : "+l);
            if(l < r)
            {
                 
                int  m =l+ (r-l)/2;
                  yield return new WaitForSeconds(2.0f);
                 StartCoroutine(MergeSort(unsortedList,randomNumber, l, m));
                   yield return new WaitForSeconds(2.0f);
                  StartCoroutine(MergeSort(unsortedList,randomNumber, m+1, r));
                    yield return new WaitForSeconds(2.0f);
                  StartCoroutine(merge(unsortedList,randomNumber, l, m, r));
                yield return new WaitForSeconds(2.0f);
            }
    }
    // Update is called once per frame
    void Update()
    {
          

     
    }
}
