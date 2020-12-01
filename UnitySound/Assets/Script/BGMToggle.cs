using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/**
 * @file BGMToggle.cs
 * @brief BGMのトグルを操作するクラス
 * @author Kodai Nakata
 */

/**
 * @class BGMToggle
 * @brief BGMのトグル用のクラス
 */
public class BGMToggle : MonoBehaviour
{
    //! トグル
    Toggle toggle;

    /**
     * @brief 最初のフレームに入る前に呼び出される関数
     */
    void Start()
    {
        toggle = GetComponent<Toggle>();
        SoundManager.GetInstance().PlayBgm(toggle.isOn);
    }

    /**
     * @brief チェックが変更されたときの処理
     */
    public void OnCheckedChanged()
    {
        SoundManager.GetInstance().PlayBgm(toggle.isOn);
    }
}
