using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Script pour afficher la fenètre d'aide
public class Aide : MonoBehaviour
{
       
    
    public GameObject aide;

    public void OpenPanel()
    {
        if (aide != null)
        {
            bool isActive = aide.activeSelf;
            aide.SetActive(!isActive);
        }
    }
}
