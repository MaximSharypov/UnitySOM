using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMotion : MonoBehaviour{

 float timeCounter=0;
 float speed;
 float width;
 float height;

 void Start () {
    speed = 1;
    width = 1;
    height = 1;
  }
 
 void Update()
 {
   timeCounter += Time.deltaTime;
   
   float x = Mathf.Cos (timeCounter)*width;
   float y = Mathf.Sin (timeCounter)*height;
   float z = 0;

   transform.position = new Vector3 (x, y, z);

   
 }
} 
 