using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recuperer_relique : MonoBehaviour
{
 public GameObject relique;

    public void OnTriggerEnter2D(Collider2D col)
    {
      if (col.gameObject.tag.Equals ("aeria"))
    {
            Debug.Log("Collision detectée");
           Destroy(col.gameObject);
         //  Destroy(gameObject);
          if (relique != null)
       {
            bool isActive = relique.activeSelf;
            relique.SetActive(!isActive);
        }
    }
        
    }

    /* private void OnTriggerEnter2D(Collider2D col)
     {


     }*/
}
