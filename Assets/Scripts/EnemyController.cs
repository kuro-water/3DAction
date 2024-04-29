using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)              // 何かが触れたとき
    {
        if (collider.gameObject.CompareTag("Player"))   // それが"Player"なら、
        {
            SceneManager.LoadScene("main");             // シーンを再読み込みする（リスタート）
        }
    }
}
