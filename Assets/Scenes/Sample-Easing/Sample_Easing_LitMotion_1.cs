using UnityEngine;
using LitMotion;
using LitMotion.Extensions;

public class Sample_Easing_LitMotion_1 : MonoBehaviour
{
    void Start()
    {
        LMotion.Create(-2f, 2f, 3f)
            // 速度を徐々に加速させる.
            .WithEase(Ease.InCirc)
            .BindToPositionX(transform);
    }
}

