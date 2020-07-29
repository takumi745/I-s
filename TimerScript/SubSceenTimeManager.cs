using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubSceenTimeManager : MonoBehaviour
{ 
    public static int ClearTime = 0;
    float LimitedTime = 0;
    private bool ClearLoadFlag;
    string scene = null;
    string nowscene;
    void Start()
    {
        ClearTime = 0;
        ClearLoadFlag = true;
        nowscene = "SubScene";
    }

    void Update()
    {
        //クリアから時間停止処理及び、タイムオーバーの時の時間リセットしなければ・・・

        if (scene == nowscene)
        {
            LimitedTime -= Time.deltaTime;
            if (0 < LimitedTime)
            {
                if (ClearLoadFlag)
                {
                    ClearTime = (int)LimitedTime;
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
        ClearTime -= time;
    }
    public void LimitTime(int time, string scenename)
    {
        LimitedTime = time;
        scene = scenename;
    }
    public static int GetTime()
    {
        return ClearTime;
    }
    public static void ResetTime()
    {
        ClearTime = 0;
    }
    public void TimeCountEnd()
    {
        ClearLoadFlag = false;
    }
    //Time.timeScale = 0.1f;
    //でゲーム全体がスローになるらしい

}
