using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public int score = 0;               // �X�R�A�ϐ�
    public TextMeshProUGUI scoreText;   // �X�R�A�\���p�e�L�X�g

    // �Q�[���J�n���Ɉ�x�������s�����֐�
    void Start()
    {
        score = 0;  // �X�R�A��0�ɏ�����
    }

    // ���t���[�����s�����֐�
    void Update()
    {
        scoreText.text = $"Score: {score}";  // �X�R�A�\���p�e�L�X�g�ɃX�R�A��\��
    }

    public void AddScore(int point)  // �X�R�A�����Z����֐�
    {
        score += point;  // �X�R�A�����Z
    }
}