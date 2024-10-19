using UnityEngine;
using LitMotion;
using LitMotion.Extensions;

public class Sample_TweenScale_LitMotion_2 : MonoBehaviour
{
    void Start()
    {
        LMotion                     　   // LitMotionの静的クラス
            .Create(-2f, 2f, 5f) 　　    // が5秒かけて-2から2に変化する動作を作る
            .BindToPositionX(transform); // 動作とtransformのpositionXと関連付ける.
    }

    void Update()
    {

    }
}

