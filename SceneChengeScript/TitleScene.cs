using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("TiTleSelect");//シーン名が入る
        //シーンが重いのであれば、別の物を使用する
    }
}
