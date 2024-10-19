using UnityEngine;
using LitMotion;
using LitMotion.Extensions;

public class Sample_TweenScale_LitMotion_1 : MonoBehaviour
{
    void Start()
    {
        // 5秒かけて-2から2に変化する動作をtransformのpositionXと関連付ける.
        LMotion.Create(-2f, 2f, 5f).BindToPositionX(transform);
    }
}

