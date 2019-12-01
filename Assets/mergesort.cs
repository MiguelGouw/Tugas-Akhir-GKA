using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class mergesort : MonoBehaviour
{
    public Text leftLabel;
    public Text rightLabel;
    public int NumberOfSphere;
    public GameObject[] Spheres;
    public int[] dataSphere = new int[10];

    public void StartMerge()
    {  
      InitializeCube(dataSphere);
      StartCoroutine(MergeSort(Spheres, 0, Spheres.Length-1)); 
    }

    void InitializeCube(int[] number)
    {
      Spheres = new GameObject[NumberOfSphere];  
      for(int i = 0; i< NumberOfSphere; i++)
      {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        Debug.Log("Nilai pertama : "+number[i]);
        sphere.transform.localScale = new Vector3(1f, 1f, 1);
        sphere.transform.position = new Vector3(i, number[i], 1);
        sphere.transform.parent = this.transform;
        GameObject childObj = new GameObject();
        childObj.transform.parent = sphere.transform;         
        TextMesh sphereText = childObj.AddComponent<TextMesh>();
        sphereText.text = number[i].ToString();
        sphereText.characterSize = 1;
        sphereText.fontSize = 8;
        sphereText.fontStyle = FontStyle.Normal;
        sphereText.anchor = TextAnchor.MiddleCenter;
        sphereText.color = Color.black;
        sphereText.alignment = TextAlignment.Center;
        sphereText.transform.position = new Vector3(sphere.transform.position.x,sphere.transform.position.y,sphere.transform.position.z);
        Spheres[i] = sphere;
      }
    }
    
    IEnumerator merge(GameObject[] input, int l, int m, int r)
    {
      int i, j, k;
      int n1 = m - l + 1;
      int n2 = r - m;
      yield return new WaitForSeconds(2.0f);
      GameObject[] left = new GameObject[n1];
      GameObject[] right = new  GameObject[n2];
      Vector3[] leftpos = new Vector3[n1];
      Vector3[] rightpos= new Vector3[n2];;
      int[] angkaleft = new int[n1];
      int[] angkaright = new int[n2];
      float x=0;
      float y=0; 

      for (i = 0; i < n1; i++)
      {
     
        yield return new WaitForSeconds(2.0f);
        x=-7.57f;
        left[i] = input[l + i];
        leftpos[i] = input[l+i].transform.localPosition;
        Debug.Log("Nilai kiri:"+ left[i].transform.localPosition.y );
        LeanTween.moveLocalX(left[i],x,1);
        LeanTween.moveLocalY(left[i],input[l+i].transform.localPosition.y,1);
        LeanTween.moveLocalZ(left[i],1,.5f).setLoopPingPong(2);
        LeanTween.color(left[i],Color.green,1f);         
      }    
      
      for (j = 0; j < n2; j++)
      {
        
        yield return new WaitForSeconds(2.0f);
        x=6.0f;       
        right[j] = input[m + 1 + j];
        rightpos[j] =input[m+1+j].transform.localPosition;
        Debug.Log("Nilai kanan:"+ right[j].transform.localPosition.y ); 
        LeanTween.moveLocalX(right[j],x,1);
        LeanTween.moveLocalY(right[j],input[m+1+j].transform.localPosition.y,1);
        LeanTween.moveLocalZ(right[j],1.5f,.5f).setLoopPingPong(2);
        LeanTween.color(right[j],Color.yellow,1f);              
           
      }

      i = 0;
      j = 0;
      k = l;    
      
      while (i < n1 && j < n2) 
      {       
          if (leftpos[i].y <= rightpos[j].y) 
        {                
          yield return new WaitForSeconds(2.0f);
          x=-7.57f;               
          input[k] = left[i];
          LeanTween.moveLocalX(input[k],x,1);             
          LeanTween.moveLocalZ(input[k],1.5f,.5f).setLoopPingPong(2);
          LeanTween.moveLocalY(input[k],leftpos[i].y,1).setLoopPingPong();
          LeanTween.color(input[k],Color.green,1f);
          i++;   
        } 
        else
        { 
          yield return new WaitForSeconds(2.0f);
          x=6.0f;
          input[k] = right[j];
          LeanTween.moveLocalX(input[k],x,1);
          LeanTween.moveLocalZ(input[k],1.5f,.5f).setLoopPingPong(2);
          LeanTween.moveLocalY(input[k],rightpos[j].y,1).setLoopPingPong();
          LeanTween.color(input[k],Color.yellow,1f);
          j++; 
                 
        } 
        k++;    
      } 
     
      while (i < n1) 
      { 
          yield return new WaitForSeconds(2.0f);
          x=-7.57f;
          input[k] = left[i];
        
          LeanTween.moveLocalX(input[k],x,1);
          LeanTween.moveLocalZ(input[k],1.5f,.5f).setLoopPingPong(2);
          LeanTween.moveLocalY(input[k],leftpos[i].y,1).setLoopPingPong();
          LeanTween.color(input[k],Color.green,1f);
          i++; 
          k++; 
      }     
      while (j < n2) 
      { 
          yield return new WaitForSeconds(2.0f);
          x=6.0f;
          input[k] = right[j];
          LeanTween.moveLocalX(input[k],x,1);
          LeanTween.moveLocalZ(input[k],1.5f,.5f).setLoopPingPong(2);
          LeanTween.moveLocalY(input[k],rightpos[j].y,1).setLoopPingPong();
          LeanTween.color(input[k],Color.yellow,1f);
          j++; 
          k++;   
          
      }   
        
      for(i=r;i>=l;i--)
      {
          yield return new WaitForSeconds(2.0f);
          k--;
          input[i] = input[k];
          GameObject childObje  = new GameObject();
          childObje.transform.parent = input[i].transform;         
          TextMesh sphereText1= childObje.AddComponent<TextMesh>();
          sphereText1.text = i.ToString();
          sphereText1.characterSize = 1;
          sphereText1.fontSize = 8;
          sphereText1.fontStyle = FontStyle.Normal;
          sphereText1.anchor = TextAnchor.MiddleCenter;
          sphereText1.color = Color.black;
          sphereText1.alignment = TextAlignment.Center;
          sphereText1.transform.position = new Vector3(input[i].transform.position.x,input[i].transform.position.y+2.0f,input[i].transform.position.z);         
          LeanTween.moveLocalX(input[i],0,.5f);
          LeanTween.moveLocalZ(input[i],1.5f,.5f).setLoopPingPong(2);
          LeanTween.moveLocalY(input[i],input[k].transform.localPosition.y,1).setLoopPingPong(1);
          LeanTween.color(input[i],Color.white,1f);  
      }     
    }     

    IEnumerator MergeSort(GameObject[] unsortedList, int l, int r )
    {   
      
      if(l < r)
      { 
         yield return new WaitForSeconds(2.0f);
        int  m = (l+r)/2;  
        yield return MergeSort(unsortedList, l, m);
        yield return MergeSort(unsortedList, m+1, r);
        yield return merge(unsortedList, l, m, r);    
      }   
    }

    void Update()
    {
      //untuk pause and play
      if(Input.GetKey(KeyCode.Space))
      {
       Time.timeScale = 0;
      }
      else if(Input.GetKey(KeyCode.K))
      {
        Time.timeScale = 1;
      }    
    }
}
