using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCoin : MonoBehaviour
{
    [SerializeField] private GameObject Coin;

    // ゲーム開始時に一度だけ実行される関数
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

    /* C#とpythonでのfor文の違い
     * 
     * pythonのfor文の例：
     * for i in range(0, 10, 2):
     *     print(i)
     * 
     * C#(Unity)のfor文の例：
     * for(int i = 0; i < 10; i += 2){
     *     Debug.Log(i);
     * }
     * 
     * pythonでは、range関数を用いて、
     * 
     * for i in range(初期値, 終了値, 増加値):
     * 
     * と指定する。
     * 
     * このrange()の部分がC#では置き換わり、
     * 
     * for (int i = 初期値; i < 終了値; i += 増加値){}
     * 
     * と指定する
     * 
     * また、どちらも終了値は含まれない。
     * 例えば、1,2,3,4,5を出力したければ、
     * 
     * for i in range(0, 6, 1):
     * 
     * または
     * 
     * for (int i = 0; i < 6; i += 1){}
     * 
     * と指定する。
     * なお、C#では、
     * 
     * for (int i = 0; i <= 5; i += 1){}
     * 
     * としてもよい。<= とすると、終了値を含む。
     */
}
