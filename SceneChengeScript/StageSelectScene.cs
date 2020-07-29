using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelectScene : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            SceneManager.LoadScene("Stage1");//シーン名が入る
            //シーンが重いのであれば、別の物を使用する
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            SceneManager.LoadScene("Stage2");//シーン名が入る
            //シーンが重いのであれば、別の物を使用する
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            SceneManager.LoadScene("Stage3");//シーン名が入る
            //シーンが重いのであれば、別の物を使用する
        }
        if(Input.GetKeyDown(KeyCode.Return))
            SceneManager.LoadScene("TitleSelect");
    }
}
