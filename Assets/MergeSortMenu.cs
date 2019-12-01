using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class MergeSortMenu : MonoBehaviour
{
    public mergesort mergeSort;
    public mergesort ActiveSorter;
    public InputField InputNumberOfSphere;
     public int[] nilaidata = new int[20];
     public void StartMerge()
    {
        // untuk set data array sphere
        String[] words = InputNumberOfSphere.text.Split(',');
        ActiveSorter = Instantiate(mergeSort);
        int temp=0;
         for(int i = 0; i< ActiveSorter.NumberOfSphere;i++)
         {
            nilaidata[i] = Int32.Parse(words[i]);
            ActiveSorter.dataSphere[i] = nilaidata[i];  
        }
         ActiveSorter.StartMerge();      
    }
    public void ResetSort()
    {
        Destroy(ActiveSorter.gameObject);
    }
    void Update()
    {
        
    }
    public void Nilai(float newValue){
        //slow, fast forward
         Time.timeScale = newValue;
         Debug.Log("value"+ newValue);
         
    }
    
}
