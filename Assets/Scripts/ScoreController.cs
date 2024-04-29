using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public int score = 0;               // スコア変数
    public TextMeshProUGUI scoreText;   // スコア表示用テキスト

    // ゲーム開始時に一度だけ実行される関数
    void Start()
    {
        score = 0;  // スコアを0に初期化
    }

    // 毎フレーム実行される関数
    void Update()
    {
        scoreText.text = $"Score: {score}";  // スコア表示用テキストにスコアを表示
    }

    public void AddScore(int point)  // スコアを加算する関数
    {
        score += point;  // スコアを加算
    }
}
