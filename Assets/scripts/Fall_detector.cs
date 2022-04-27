using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class Fall_detector : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject ennemi;
    //public GameObject player;

 void OnCollisionEnter2D(Collision2D col)
{
    if (col.gameObject.tag == "game_over")
    {

     SceneManager.LoadScene("GameOver");
      Debug.Log("collision détectée");
    }
}
}
