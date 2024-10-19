using UnityEngine;
using LitMotion;
using LitMotion.Extensions;

// IEnumeratorを使用するために必要です
using System.Collections;

public class Sample_Coroutine_LitMotion_1 : MonoBehaviour
{
    void Start()
    {
        // MonoBehaviourのStart()からCoroutineExample()を開始する.
        StartCoroutine(CoroutineExample());
    }

    IEnumerator CoroutineExample()
    {
        // 下から出てくるまで実行する
        yield return LMotion.Create(-2f, 0f, 1f).BindToPositionY(transform).ToYieldInteraction();

        // １回転するまで実行する
        yield return LMotion.Create(0f, 360f, 1f).BindToLocalEulerAnglesZ(transform).ToYieldInteraction();

        // 小さくなるまで実行する
        yield return LMotion.Create(1f, 0f, 1f).BindToLocalScaleY(transform).ToYieldInteraction();
    }
}

