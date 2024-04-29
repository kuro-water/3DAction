using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody rb; //Rigidbody���i�[����ϐ�
    private Vector3 force;�@//�̗͂͗ʂ��i�[����ϐ�

    // �Q�[���J�n���Ɉ�x�������s�����֐�
    void Start()
    {
        rb = this.GetComponent<Rigidbody>(); //rb�ɂ��̃X�N���v�g���A�^�b�`����Ă���I�u�W�F�N�g��Rigidbody���i�[����B
        force = new Vector3(0.0f, 0.0f, 0.0f);//force�ɗ͗ʂ̏����l���i�[
    }

    // ���t���[�����s�����֐�
    void Update()
    {
        if (rb == null) //����rb��null�Ȃ�A
        {
            return; //���������Ɋ֐����I������
        }

        //force�𖈃t���[���������B��������Ȃ��Əd�͂����f����Ȃ�
        force = new Vector3(0f, 0f, 0f);


        if (Input.GetKeyDown(KeyCode.Space)) //�����X�y�[�X�L�[�������ꂽ��A
        {
            force.y += 500.0f; //y���W��500.0f�̗͂�������
        }

        if (Input.GetKey(KeyCode.D)) //����D�L�[�������ꂽ��A
        {
            force.x += 10.0f;//x���W��10.0f�̗͂�������
        }

        //�ύX����force�𔽉f������
        rb.AddForce(force);
    }
}
