using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class BackgroundAnimation : MonoBehaviour
{
    public float timeStart = 35f;
    public Text Timer;
    // public Point[] sequence;
    public GameObject cow;
    public GameObject cow2;
    public GameObject cow3;
    public GameObject cow4;
    public GameObject cow5;
    public GameObject cow6;
    public GameObject cow7;

    private float x = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
     

        // sequence = Point[]{
        //     Point(1, 1.0),
        //     Point(1, 1.0),
        //     Point(1, 1.0),
        // };

    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;
        Timer.text = Mathf.Round(timeStart).ToString ();

        string cow_name = String.Concat("cow", 1);
        string cow_name2 = String.Concat("cow", 2);
        string cow_name3 = String.Concat("cow", 3);
        string cow_name4 = String.Concat("cow", 4);
        string cow_name5 = String.Concat("cow", 5);
        string cow_name6 = String.Concat("cow", 6);
        string cow_name7 = String.Concat("cow", 7);
        
        
        cow = GameObject.Find(cow_name);
        cow2 = GameObject.Find(cow_name2);
        cow3= GameObject.Find(cow_name3);
        cow4 = GameObject.Find(cow_name4);
        cow5 = GameObject.Find(cow_name5);
        cow6 = GameObject.Find(cow_name6);
        cow7 = GameObject.Find(cow_name7);

        GameObject flash = GameObject.Find("flash");
        GameObject romashka = GameObject.Find("romashka");
        GameObject marker_orange = GameObject.Find("marker_orange");

        flash.transform.position = new Vector3(cow.transform.position.x, flash.transform.position.y, flash.transform.position.z);
        romashka.transform.position = new Vector3(cow.transform.position.x, romashka.transform.position.y, romashka.transform.position.z);
        

        //Debug.Log(flash.transform.position);
        //Debug.Log(romashka.transform.position);
        //Debug.Log(marker_orange.transform.position);

        
      

            if (timeStart < (22 * x))
        {
            marker_orange.transform.position = new Vector3(cow5.transform.position.x, marker_orange.transform.position.y, marker_orange.transform.position.z);
        }       
            if (timeStart < (21 * x))
        {
            marker_orange.transform.position = new Vector3(cow3.transform.position.x, marker_orange.transform.position.y, marker_orange.transform.position.z);
        }
            if (timeStart < (20 * x))
        {
            marker_orange.transform.position = new Vector3(cow3.transform.position.x, marker_orange.transform.position.y, marker_orange.transform.position.z);
        }       
            if (timeStart < (19 * x))
        {
            marker_orange.transform.position = new Vector3(cow5.transform.position.x, marker_orange.transform.position.y, marker_orange.transform.position.z);
        }
            if (timeStart < (18 * x))
        {
            marker_orange.transform.position = new Vector3(cow3.transform.position.x, marker_orange.transform.position.y, marker_orange.transform.position.z);
        }       
            if (timeStart < (17 * x))
        {
            marker_orange.transform.position = new Vector3(cow3.transform.position.x, marker_orange.transform.position.y, marker_orange.transform.position.z);
        }
            if (timeStart < (16 * x))
        {
            marker_orange.transform.position = new Vector3(cow5.transform.position.x, marker_orange.transform.position.y, marker_orange.transform.position.z);
        }       
            if (timeStart < (15 * x))
        {
            marker_orange.transform.position = new Vector3(cow4.transform.position.x, marker_orange.transform.position.y, marker_orange.transform.position.z);
        }   
            if (timeStart < (14 * x))
        {
            marker_orange.transform.position = new Vector3(cow3.transform.position.x, marker_orange.transform.position.y, marker_orange.transform.position.z);
        }       
            if (timeStart < (13 * x))
        {
            marker_orange.transform.position = new Vector3(cow2.transform.position.x, marker_orange.transform.position.y, marker_orange.transform.position.z);
        }
            if (timeStart < (12 * x))
        {
            marker_orange.transform.position = new Vector3(cow.transform.position.x, marker_orange.transform.position.y, marker_orange.transform.position.z);
        }       
            if (timeStart < (11 * x))
        {
            marker_orange.transform.position = new Vector3(cow6.transform.position.x, marker_orange.transform.position.y, marker_orange.transform.position.z);
        }
            if (timeStart < (9 * x))
        {
            marker_orange.transform.position = new Vector3(cow6.transform.position.x, marker_orange.transform.position.y, marker_orange.transform.position.z);
        }       
            if (timeStart < (8 * x))
        {
            marker_orange.transform.position = new Vector3(cow5.transform.position.x, marker_orange.transform.position.y, marker_orange.transform.position.z);
        }      
            if (timeStart < (7 * x))
        {
            marker_orange.transform.position = new Vector3(cow3.transform.position.x, marker_orange.transform.position.y, marker_orange.transform.position.z);
        }    
            if (timeStart < (6 * x))
        {
            marker_orange.transform.position = new Vector3(cow6.transform.position.x, marker_orange.transform.position.y, marker_orange.transform.position.z);
        }
            if (timeStart < (5 * x))
        {
            marker_orange.transform.position = new Vector3(cow5.transform.position.x, marker_orange.transform.position.y, marker_orange.transform.position.z);
        }       
            if (timeStart < (4 * x))
        {
            marker_orange.transform.position = new Vector3(cow4.transform.position.x, marker_orange.transform.position.y, marker_orange.transform.position.z);
        }
            if (timeStart < (3 * x))
        {
            marker_orange.transform.position = new Vector3(cow6.transform.position.x, marker_orange.transform.position.y, marker_orange.transform.position.z);
        }       
            if (timeStart < (2 * x))
        {
            marker_orange.transform.position = new Vector3(cow2.transform.position.x, marker_orange.transform.position.y, marker_orange.transform.position.z);
        } 
            if (timeStart < (1 * x))
        {
            marker_orange.transform.position = new Vector3(cow.transform.position.x, marker_orange.transform.position.y, marker_orange.transform.position.z);
        }                                                                               
    }
        
}