using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject clearText; // �N���A�e�L�X�g���w�肷��

    void OnCollisionEnter(Collision collision)          // �������G�ꂽ�Ƃ�
    {
        if (collision.gameObject.CompareTag("Player"))  // ���ꂪ"Player"�Ȃ�A
        {
            clearText.SetActive(true);                  // �N���A�e�L�X�g��\��������
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        clearText.SetActive(false); // �N���A�e�L�X�g���B��
    }

    // Update is called once per frame
    void Update()
    {

    }
}
