using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OneClick : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadSceneMain()
    {
        Debug.Log ("Загрузка сцены");
        SceneManager.LoadScene("S1.Lake");
    }

}


