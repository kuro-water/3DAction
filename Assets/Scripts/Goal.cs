using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private GameObject clearText; // GameClear��\������e�L�X�g�I�u�W�F�N�g

    void OnCollisionEnter(Collision collision)                          // �������G�ꂽ�Ƃ�
    {
        if (collision.gameObject.CompareTag("Player"))                  // ���ꂪ"Player"�Ȃ�A
        {
            clearText.SetActive(true);                                  // �N���A�e�L�X�g��\��������
            Destroy(collision.gameObject.GetComponent<Rigidbody>());    // Player��Rigidbody�������i�������~�߂�j
        }
    }

    // �Q�[���J�n���Ɉ�x�������s�����֐�
    void Start()
    {
        clearText.SetActive(false); // �N���A�e�L�X�g���B��
    }
}
