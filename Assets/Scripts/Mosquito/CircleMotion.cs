using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMotion : MonoBehaviour
{
    public GameObject mosquito1;
    public GameObject mosquito2;
    public GameObject mosquito3
    ;
    public Transform center;

    [SerializeField]
    float radius = 2f, angularSpeed = 2f;
    float positionX, positionY, angle = 0f;
    float timeDestroy = 3f;

    Vector3 spawnPos;

    private UnityEngine.Object enemyRef;



    void Start()
    {
        spawnPos = transform.position;
        enemyRef = Resources.Load("mosquito1_1");
    }

    // Update is called once per frame
    void Update()
    {
        
        positionX = center.position.x + Mathf.Cos(angle) * radius;
        positionY = center.position.y + Mathf.Sin(angle) * radius;
        transform.position = new Vector2(positionX, positionY);
        angle = angle + Time.deltaTime * angularSpeed;

        if (angle >= 360f)
        {
            angle = 0f;
        }

        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
            RaycastHit _hit;
            if (Physics.Raycast(ray, out _hit, Mathf.Infinity)) 
            {
                if (_hit.transform.tag == "DestroyObject")
                {                   
                    _hit.transform.gameObject.SetActive(false);
                    Invoke("Respawn", timeDestroy);
                } 
            }
        }
    }
    void Respawn()
    {
        GameObject enemyCopy = (GameObject)Instantiate(enemyRef);
       
        
        Destroy(gameObject);
    }

}
