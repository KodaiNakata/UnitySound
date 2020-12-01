using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * @file SEButton.cs
 * @brief SEのボタンを操作するクラス
 * @author Kodai Nakata
 */

/**
 * @class SEButton
 * @brief SEのボタン用のクラス
 */
public class SEButton : MonoBehaviour
{
    /**
     * @brief クリック時の処理
     */
    public void OnClick()
    {
        SoundManager.GetInstance().PlaySe();
    }
}
