using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    // キャラクターオブジェクト
    [SerializeField] private GameObject playerObj;
    // カメラとの距離
    private Vector3 offset;

    // ゲーム開始時に一度だけ実行される関数
    void Start()
    {
        offset = transform.position - playerObj.transform.position;
    }

    // 毎フレーム実行される関数
    void LateUpdate()
    {
        transform.position = playerObj.transform.position + offset;
    }
}
