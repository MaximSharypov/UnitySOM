using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class BackgroundAnimation : MonoBehaviour
{
    public float timeStart = 21f;
    public Text Timer;
    // public Point[] sequence;
    public GameObject cow;

    // Start is called before the first frame update
    void Start()
    {
        Timer.text = timeStart.ToString ();

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
        cow = GameObject.Find(cow_name);
        GameObject flash = GameObject.Find("flash");

        flash.transform.position = new Vector3(cow.transform.position.x, flash.transform.position.y, flash.transform.position.z);
        Debug.Log(flash.transform.position);

    }
        
}