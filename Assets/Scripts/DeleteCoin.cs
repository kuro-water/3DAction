using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCoin : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)                          // �������G�ꂽ�Ƃ�
    {
        if (collision.gameObject.CompareTag("Player"))                  // ���ꂪ"Player"�Ȃ�A
        {
            GameObject sm = GameObject.Find("StageManager");            // StageManager���擾
            ScoreController sc = sm.GetComponent<ScoreController>();    // ScoreController���擾
            sc.AddScore(1);                                             // �X�R�A��10���Z

            Destroy(gameObject);                                        // ���g������
        }
    }
}
