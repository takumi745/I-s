using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3TimeManager : MonoBehaviour
{
    public static int ClearTime3 = 0;
    float LimitedTime = 0;
    private bool ClearLoadFlag;
    string scene = null;
    string nowscene;
    void Start()
    {
        ClearTime3 = 0;
        ClearLoadFlag = true;
        nowscene = "Stage3";
    }

    // Update is called once per frame
    void Update()
    {
        /*if文などでフェード終了とかから
         * 計測できるようにするとか
         * したほうがいいかも？
         * あるいはプレイヤーの初期操作以降…
         */

        if (scene == nowscene)
        {
            LimitedTime -= Time.deltaTime;
            if (0 < LimitedTime)
            {
                if (ClearLoadFlag)
                {
                    ClearTime3 = (int)LimitedTime;
                }
            }
            else
            {
                Debug.Log("GameOver");
            }
            gameObject.transform.GetComponent<GameTimerDirector>().NowTime = LimitedTime;
        }
    }
    public static void PenaltyTime(int time)
    {
        ClearTime3 -= time;
    }
    public void LimitTime(int time, string scenename)
    {
        LimitedTime = time;
        scene = scenename;
    }
    public static int GetTime()
    {
        return ClearTime3;
    }
    public static void ResetTime()
    {
        ClearTime3 = 0;
    }
    public void TimeCountEnd()
    {
        ClearLoadFlag = false;
    }
}

//Time.timeScale = 0.1f;
//でゲーム全体がスローになるらしい
