using System.Collections;
using System.Collections.Generic; 
using UnityEngine; 
//using SimpleJSON;

public class DeplacerPierre : MonoBehaviour {

 public Vector3 pointA;
 public Vector3 pointB;

 public float maxSpeed = 1;
 public bool keyHit = false;
 
     public GameObject personnage;
    public GameObject pierre;
    [SerializeField] int time;

 void Start()
 {
 }
 // Update is called once per frame
 void Update()
 {
     if((Vector3.Distance (personnage.transform.position, pierre.transform.position) < 5) && (Input.GetKeyDown(KeyCode.H)))
     {

     
         keyHit = true;
         
     }
     if (keyHit == true)
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
    yield return new WaitForSeconds(5);

             var change = maxSpeed * Time.deltaTime;
         transform.position = Vector3.MoveTowards(transform.position, pointB, change);
}
   
     }
 }
