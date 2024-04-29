using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCoin : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)                          // 何かが触れたとき
    {
        if (collision.gameObject.CompareTag("Player"))                  // それが"Player"なら、
        {
            GameObject sm = GameObject.Find("StageManager");            // StageManagerを取得
            ScoreController sc = sm.GetComponent<ScoreController>();    // ScoreControllerを取得
            sc.AddScore(1);                                             // スコアを10加算

            Destroy(gameObject);                                        // 自身を消す
        }
    }
}
