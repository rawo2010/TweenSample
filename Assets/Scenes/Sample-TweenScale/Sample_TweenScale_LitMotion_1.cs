using UnityEngine;
using LitMotion;
using LitMotion.Extensions;

public class Sample_TweenScale_LitMotion_1 : MonoBehaviour
{
    void Start()
    {
        LMotion
            .Create(-2f, 2f, 5f)
            .BindToPositionX(transform);
    }
}

