using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attaque : MonoBehaviour
{
        //  public float totaltime = 5;
public GameObject heros;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
            if (Input.GetKey(KeyCode.H) )


        
     {

        // totaltime = totaltime - Time.deltaTime;
          /* bool isActive = air_expirer.activeSelf;
            air_expirer.SetActive(!isActive);*/
      //    GetComponent< UnityEngine.Animation > ().Play("expiration");
  // yield return new WaitForSeconds(5f);
         //   Debug.Log("Enter");
          if (anim != null) 
            {
       anim.Play("expiration");
     
   
            }
             
     }

    }
}
