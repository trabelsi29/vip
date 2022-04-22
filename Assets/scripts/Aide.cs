using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aide : MonoBehaviour
{
        // Start is called before the first frame update
    
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
