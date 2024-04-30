using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody rb; //Rigidbodyを格納する変数
    private Vector3 force;　//力の力量を格納する変数

    // ゲーム開始時に一度だけ実行される関数
    void Start()
    {
        rb = this.GetComponent<Rigidbody>(); //rbにこのスクリプトがアタッチされているオブジェクトのRigidbodyを格納する。
        force = new Vector3(0.0f, 0.0f, 0.0f);//forceに力量の初期値を格納
    }

    // 毎フレーム実行される関数
    void Update()
    {
        if (rb == null) //もしrbがnullなら、
        {
            return; //何もせずに関数を終了する
        }

        //forceを毎フレーム初期化。これをしないと重力が反映されない
        force = new Vector3(0f, 0f, 0f);


        if (Input.GetKeyDown(KeyCode.Space)) //もしスペースキーが押されたら、
        {
            force.y += 500.0f; //y座標に500.0fの力を加える
        }

        if (Input.GetKey(KeyCode.D)) //もしDキーが押されたら、
        {
            force.x += 10.0f;//x座標に10.0fの力を加える
        }

        //変更したforceを反映させる
        rb.AddForce(force);
    }
}
