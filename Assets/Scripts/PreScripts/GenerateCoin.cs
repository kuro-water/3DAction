using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCoin : MonoBehaviour
{
    [SerializeField] private GameObject Coin;

    // �Q�[���J�n���Ɉ�x�������s�����֐�
    void Start()
    {
        for (int x = -4; x < 5; x += 2)
        {
            for (int y = 0; y < 7; y += 2)
            {
                Instantiate(Coin, new Vector3(x, y, 3), Quaternion.identity);
            }
        }
    }

    /* C#��python�ł�for���̈Ⴂ
     * 
     * python��for���̗�F
     * for i in range(0, 10, 2):
     *     print(i)
     * 
     * C#(Unity)��for���̗�F
     * for(int i = 0; i < 10; i += 2){
     *     Debug.Log(i);
     * }
     * 
     * python�ł́Arange�֐���p���āA
     * 
     * for i in range(�����l, �I���l, �����l):
     * 
     * �Ǝw�肷��B
     * 
     * ����range()�̕�����C#�ł͒u�������A
     * 
     * for (int i = �����l; i < �I���l; i += �����l){}
     * 
     * �Ǝw�肷��
     * 
     * �܂��A�ǂ�����I���l�͊܂܂�Ȃ��B
     * �Ⴆ�΁A1,2,3,4,5���o�͂�������΁A
     * 
     * for i in range(0, 6, 1):
     * 
     * �܂���
     * 
     * for (int i = 0; i < 6; i += 1){}
     * 
     * �Ǝw�肷��B
     * �Ȃ��AC#�ł́A
     * 
     * for (int i = 0; i <= 5; i += 1){}
     * 
     * �Ƃ��Ă��悢�B<= �Ƃ���ƁA�I���l���܂ށB
     */
}
