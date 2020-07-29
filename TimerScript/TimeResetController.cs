using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeResetController : MonoBehaviour
{
    void Start()
    {
        Stage1TimeManager.ResetTime();
        Stage2TimeManager.ResetTime();
        Stage3TimeManager.ResetTime();
        //カーソル表示・カーソルを画面内にロック
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
}
