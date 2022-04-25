using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public Image timerImage;
    public Text timerText;
    public float totaltime = 5;


    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(KeyCode.H))
     {
        totaltime = totaltime - Time.deltaTime;
        if ( totaltime > 0)
        {
       
        timerText.text = totaltime.ToString("0");
        timerImage.fillAmount -= 1.0f / 5 * Time.deltaTime;
     }
     else 
     {
         timerText.text = "5";
         timerImage.fillAmount = 1;
         totaltime = 5;
     }
        
    }
    }
}
