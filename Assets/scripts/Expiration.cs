using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expiration : MonoBehaviour
{
    public GameObject timer;

    public void OpenTimer()
    {
        if (timer != null)
        {


             
            bool isActive = timer.activeSelf;
            timer.SetActive(!isActive);
        
        }
    }
    // Update is called once per frame

}
