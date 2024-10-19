using UnityEngine;
using LitMotion;
using LitMotion.Extensions;

// Textを使うために必要です
using UnityEngine.UI;
using Unity.VisualScripting;

// このスクリプトをアタッチするゲームオブジェクトはTextが必須です
[RequireComponent(typeof(Text))]
public class Sample_Easing_LitMotion_3 : MonoBehaviour
{
#region optional
    private void Awake()
    {
        var text = GetComponent<Text>();
        var ls = text.transform.localScale;
        ls.y = 0.0f;
        text.transform.localScale = ls;
    }
#endregion //optional

    void Start()
    {
        // Textコンポーネントを取得する
        var text = GetComponent<Text>();

        LMotion.Create(0f, 1f, 3f)
            // 動作開始を0.5秒遅らせる
            .WithDelay(0.5f)
            .WithEase(Ease.OutCirc)
            // transform.localscale.yと関連付ける
            .BindToLocalScaleY(text.transform);

        var from = Color.red;
        var to = text.color;

        LMotion.Create(from, to, 3f)
            // 動作開始を0.5秒遅らせる
            .WithDelay(0.5f)
            .WithEase(Ease.OutCirc)
            // text.colorと関連付ける
            .BindToColor(text);
    }
}

