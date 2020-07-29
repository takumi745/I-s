using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1TimeManager : MonoBehaviour
{
    private static int ClearTime1 = 0;
    float LimitedTime = 0;
    private bool ClearLoadFlag;
    string scene = null;
    string nowscene;
    void Start()
    {
        ClearTime1 = 0;
        ClearLoadFlag = true;
        nowscene = "Stage1";
    }

    // Update is called once per frame
    void Update()
    {
        if (scene == nowscene)
        {
            LimitedTime -= Time.deltaTime;
            if (0 < LimitedTime)
            {
                if (ClearLoadFlag)
                {
                    ClearTime1 = (int)LimitedTime;
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
        ClearTime1 -= time;
    }
    public void LimitTime(int time, string scenename)
    {
        LimitedTime = time;
        scene = scenename;
    }
    public static int GetTime()
    {
        return ClearTime1;
    }
    public static void ResetTime()
    {
        ClearTime1 = 0;
    }
    public void TimeCountEnd()
    {
        ClearLoadFlag = false;
    }
}

//Time.timeScale = 0.1f;
//でゲーム全体がスローになるらしい
