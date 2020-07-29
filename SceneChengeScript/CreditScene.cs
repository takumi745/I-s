using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditScene0 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)//何らかのキー操作
        {
            SceneManager.LoadScene("TiTleSelect");//シーン名が入る
        }
    }


}
