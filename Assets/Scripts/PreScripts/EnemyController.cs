using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)              // �������G�ꂽ�Ƃ�
    {
        if (collider.gameObject.CompareTag("Player"))   // ���ꂪ"Player"�Ȃ�A
        {
            SceneManager.LoadScene("main");             // �V�[�����ēǂݍ��݂���i���X�^�[�g�j
        }
    }
}
