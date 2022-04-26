using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attaque : MonoBehaviour
{
    // Start is called before the first frame update
  public GameObject air_expirer;

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKey(KeyCode.H))
     {
           bool isActive = air_expirer.activeSelf;
            air_expirer.SetActive(!isActive);
         // GetComponent< UnityEngine.Animation > ().Play("expiration");
             
     }
    }
}
