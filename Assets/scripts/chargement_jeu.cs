using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chargement_jeu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
          //Start the coroutine we define below named ChangeAfter2SecondsCoroutine().
    StartCoroutine(ChangeAfter2SecondsCoroutine());
    }

IEnumerator ChangeAfter2SecondsCoroutine()
{
    //Print the time of when the function is first called.
    Debug.Log("Started Coroutine at timestamp : " + Time.time);

    //yield on a new YieldInstruction that waits for 4 seconds.
    yield return new WaitForSeconds(3);


    //And load the scene
    Application.LoadLevel("Mission1");  //Open the first mission
}
}
