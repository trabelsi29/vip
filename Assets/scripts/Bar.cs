using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;

using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    public GameObject bar;
    public int time;

     void Start (){
            
         AnimateBar();
         

    }
    void Update (){
        
    }
    public void AnimateBar(){
        LeanTween.scaleX(bar, 1, time);
    }

}
