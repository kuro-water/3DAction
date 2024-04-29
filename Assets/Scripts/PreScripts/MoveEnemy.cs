using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    [SerializeField] private Vector3 from;
    [SerializeField] private Vector3 to;
    [SerializeField] private float speed;
    public bool isLoop;

    private float startTime;
    private GameObject player;

    // �Q�[���J�n���Ɉ�x�������s�����֐�
    void Start()
    {
        // �����ʒu��ݒ�
        transform.position = from;

        // �X�^�[�g���Ԃ��L�^
        startTime = Time.time;

        // Player�I�u�W�F�N�g���擾
        player = GameObject.Find("Player");
    }

    // ���t���[�����s�����֐�
    void Update()
    {
        Debug.Log("Player: " + player);
        if (player != null)
        {   // Player�I�u�W�F�N�g��Rigidbody�������Ă��Ȃ��ꍇ�́A�Q�[�����ł͂Ȃ��Ɣ��f���������Ȃ�
            if (player.GetComponent<Rigidbody>() == null)
            {
                return;
            }
        }

        // isLoop��false�̏ꍇ�A�������Ȃ�
        if (!isLoop)
        {
            return;
        }


        // ���̃X�s�[�h�ŉ�������
        float journeyLength = Vector3.Distance(from, to);               // 2�_�Ԃ̋������v�Z
        float pos = (Time.time - startTime) * speed / journeyLength;    // ���݂̈ʒu���v�Z
        float t = Mathf.PingPong(pos, 1.0f);                            // 0.0�`1.0�͈̔͂ɒ���
        transform.position = Vector3.Lerp(from, to, t);                 // ���݂̈ʒu���X�V
    }
}