using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreFly : MonoBehaviour
{
    public Text scoreStars;
    public int score;
    

    private int enemies;

    GameObject[] gameObjects;

     private UnityEngine.Object salute;
     private UnityEngine.Object arrow;

     

    // Start is called before the first frame update
    void Start()
    {
        
        salute = Resources.Load("stars");
        
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
                if (_hit.transform.tag == "DestroyObject")
                {                                     
                    score += 1;
                    scoreStars.text = score.ToString ("00"); 
                    if (score == 30)
                    {   
                        
        
                        Destroy(GameObject.Find("Player"));   
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
