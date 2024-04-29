using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject clearText; // クリアテキストを指定する

    void OnCollisionEnter(Collision collision)                          // 何かが触れたとき
    {
        Debug.Log("collision" + collision);
        if (collision.gameObject.CompareTag("Player"))                  // それが"Player"なら、
        {
            clearText.SetActive(true);                                  // クリアテキストを表示させる
            Destroy(collision.gameObject.GetComponent<Rigidbody>());    // PlayerのRigidbodyを消す（動きを止める）
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        clearText.SetActive(false); // クリアテキストを隠す
    }
}
