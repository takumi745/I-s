using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearTimeManager : MonoBehaviour
{
    int ScoreTime;
    private int bestScore; // ベストタイムの値を格納する変数
    public Text finishTime;  // FinishTimeテキストの変数
    public Text bestTime; // BestTimeテキストの変数
    public GameObject finishUI; // Finishオブジェクトの変数
    


    // Start is called before the first frame update
    void Start()
    {
        ScoreTime = 0;
        int t1 = Stage1TimeManager.GetTime();
        int t2 = Stage2TimeManager.GetTime();
        int t3 = Stage3TimeManager.GetTime();
        ScoreTime = t1 + t2 + t3;

        if (PlayerPrefs.HasKey("ScoreTime"))
        {
            

            bestScore = PlayerPrefs.GetInt("ScoreTime");

        }
        else
        {
            bestScore = 9999;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            finishUI.SetActive(true);

            // クリア時間を整数にしてscoreに格納
            int score = ScoreTime;

            // テキストの値を変える
            finishTime.text = "FinishTime = " + score;
            bestTime.text = "ScoreTime = " + bestScore;

            // もしクリアスコアがベストスコアより小さい場合
            if (bestScore > score)
            {
                // ベストスコアにクリアスコアを入れる
                PlayerPrefs.SetInt("BestScore", score);
            }
        }
    }
    
    void ResultTime()
    {
        Debug.Log(ScoreTime);
    }
    public void OnRetry()
    {
        SceneManager.LoadScene("Title");
        
    }
}
