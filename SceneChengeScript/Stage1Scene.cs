using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage1Scene : MonoBehaviour
{
    public bool Stage1CrearFlag;

    void State()
    {
        Stage1CrearFlag = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Stage1CrearFlag)
        {
            SceneManager.LoadScene("Stage2");//シーン名が入る 
        }
    }
}
