using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cowScore : MonoBehaviour
{
    private UnityEngine.Object salute;

    public Text scoreStars;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        salute = Resources.Load("stars3");
    }

    // Update is called once per frame
    void Update()
    {
            if(Input.GetMouseButtonDown(0))
        {      
             
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
            RaycastHit _hit;
            if (Physics.Raycast(ray, out _hit, Mathf.Infinity)) 
            {
                if (_hit.transform.tag == "Player")
                {                                     
                    score += 1;
                    scoreStars.text = score.ToString ("00"); 
                    if (score == 30)
                    {   
                         
                        Invoke("Respawn",0.1f) ;
                           
                    }                                      
                } 
            }
        }
    }
    void Respawn()
    {
        GameObject saluteCopy = (GameObject)Instantiate(salute);    
    }
}