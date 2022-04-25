using System.Collections;
using System.Collections.Generic; 
using UnityEngine; 
//using SimpleJSON;

public class DeplacerPierre : MonoBehaviour {

 public Vector3 pointA;
 public Vector3 pointB;

 public float maxSpeed = 1;
 public bool keyHit = false;
 
 void Start()
 {
 }
 // Update is called once per frame
 void Update()
 {
     if (Input.GetKey(KeyCode.L))
     {
         keyHit = true;
         
     }
     if (keyHit == true)
     {
         
         var change = maxSpeed * Time.deltaTime;
         transform.position = Vector3.MoveTowards(transform.position, pointB, change);
     }  
 
 }
}