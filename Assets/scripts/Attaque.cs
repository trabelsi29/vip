using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Cette classe Attaque considère le souffle : l'utilisation du pouvoir d'expiration
public class Attaque : MonoBehaviour
{
        //  public float totaltime = 5;
public GameObject heros;
    private Animator anim;
    private bool souffler;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
            if (Input.GetKey(KeyCode.H) )


        
     {
         anim.SetBool("souffler", true);
     }
        else 
     {
        anim.SetBool("souffler", false);
     }

     
    if((souffler) && (anim != null) )
    
            {
       anim.Play("expiration");
     
   
            }
             
     }
  
    
}
