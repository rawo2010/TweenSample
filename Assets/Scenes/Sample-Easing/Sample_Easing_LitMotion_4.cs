using UnityEngine;
using UnityEngine.UI;
using LitMotion;
using LitMotion.Extensions;

[RequireComponent(typeof(Text))]
public class Sample_Easing_LitMotion_4 : MonoBehaviour
{
    private void Awake()
    {
        var text = GetComponent<Text>();
        var ls = text.transform.localScale;
        ls.y = 0.0f;
        text.transform.localScale = ls;
    }

    void Start()
    {
        var text = GetComponent<Text>();

        var ease = Ease.OutBounce;
        var delay = 0.5f;
        var duration = 3f;

        LMotion.Create(0f, 1f, duration)
            .WithDelay(delay)
            .WithEase(ease)
            .BindToLocalScaleY(text.transform);

        var from = Color.red;
        var to = text.color;

        LMotion.Create(from, to, duration)
            .WithDelay(delay)
            .WithEase(ease)
            .BindToColor(text);
    }
}
