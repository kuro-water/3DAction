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

    // ゲーム開始時に一度だけ実行される関数
    void Start()
    {
        // 初期位置を設定
        transform.position = from;

        // スタート時間を記録
        startTime = Time.time;

        // Playerオブジェクトを取得
        player = GameObject.Find("Player");
    }

    // 毎フレーム実行される関数
    void Update()
    {
        Debug.Log("Player: " + player);
        if (player != null)
        {   // PlayerオブジェクトがRigidbodyを持っていない場合は、ゲーム中ではないと判断し何もしない
            if (player.GetComponent<Rigidbody>() == null)
            {
                return;
            }
        }

        // isLoopがfalseの場合、何もしない
        if (!isLoop)
        {
            return;
        }


        // 一定のスピードで往復する
        float journeyLength = Vector3.Distance(from, to);               // 2点間の距離を計算
        float pos = (Time.time - startTime) * speed / journeyLength;    // 現在の位置を計算
        float t = Mathf.PingPong(pos, 1.0f);                            // 0.0～1.0の範囲に調整
        transform.position = Vector3.Lerp(from, to, t);                 // 現在の位置を更新
    }
}
