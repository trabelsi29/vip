using System.Collections;
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.UI;
//using SimpleJSON;

public class DeplacerObstacle : MonoBehaviour {

 public Vector3 pointA;
 public Vector3 pointB;

 public float maxSpeed = 1;
 public bool keyHit = false;
 
     public GameObject personnage;
    public GameObject obstacle;
    [SerializeField] int time;

    public Text chrono;
 // Update is called once per frame
 void Update()
 {
     if((Vector3.Distance (personnage.transform.position, obstacle.transform.position) < 5) && (Input.GetKeyDown(KeyCode.H)))
     {

     
         keyHit = true;
         
     }
     if ((keyHit == true) && ((chrono.text == "2") || (chrono.text =="1")))
     {
                   
                   StartCoroutine(Action());
     //     yield return new WaitForSecondsRealtime(5);
       
    

      
   }
   else if (Input.GetKeyUp(KeyCode.H)) 
   {
       StopCoroutine(Action());
   }
   

   IEnumerator Action ()
{
    yield return new WaitForSeconds(2);

             var change = maxSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, pointB, change);
}
   
     }
 }