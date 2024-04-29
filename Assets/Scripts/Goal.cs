using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private GameObject clearText; // GameClearを表示するテキストオブジェクト

    void OnCollisionEnter(Collision collision)                          // 何かが触れたとき
    {
        if (collision.gameObject.CompareTag("Player"))                  // それが"Player"なら、
        {
            clearText.SetActive(true);                                  // クリアテキストを表示させる
            Destroy(collision.gameObject.GetComponent<Rigidbody>());    // PlayerのRigidbodyを消す（動きを止める）
        }
    }

    // ゲーム開始時に一度だけ実行される関数
    void Start()
    {
        clearText.SetActive(false); // クリアテキストを隠す
    }
}
