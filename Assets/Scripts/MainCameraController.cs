using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    // �L�����N�^�[�I�u�W�F�N�g
    [SerializeField] private GameObject playerObj;
    // �J�����Ƃ̋���
    private Vector3 offset;

    // �Q�[���J�n���Ɉ�x�������s�����֐�
    void Start()
    {
        offset = transform.position - playerObj.transform.position;
    }

    // ���t���[�����s�����֐�
    void LateUpdate()
    {
        transform.position = playerObj.transform.position + offset;
    }
}
