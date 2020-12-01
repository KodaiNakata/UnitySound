using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * @file SoundManager.cs
 * @brief サウンド管理するスクリプト
 * @author Kodai Nakata
 */

/**
 * @class SoundManager
 * @brief サウンド管理用のクラス
 */
public class SoundManager : MonoBehaviour
{
    //! 自クラスのインスタンス
    private static SoundManager instance;

    //! BGMのオブジェクト
    private GameObject bgmObject;

    //! BGMの音源
    private AudioClip bgmClip;

    //! BGMのAudioSource
    private AudioSource bgmSource;

    //! SEのオブジェクト
    private GameObject seObject;

    //! SEの音源
    private AudioClip seClip;

    //! SEのAudioSource
    private AudioSource seSource;

    /**
     * @brief 初期化処理
     */
    void Awake()
    {
        instance = GetComponent<SoundManager>();
        instance.bgmObject = GameObject.FindGameObjectWithTag("BGM");
        instance.bgmSource = instance.bgmObject.GetComponent<AudioSource>();
        instance.bgmClip = instance.bgmSource.clip;

        instance.seObject = GameObject.FindGameObjectWithTag("SE");
        instance.seSource = instance.seObject.GetComponent<AudioSource>();
        instance.seClip = instance.seSource.clip;
    }

    /**
     * @brief 自クラスのインスタンスを取得する
     * @return 自クラスのインスタンス
     */
    public static SoundManager GetInstance()
    {
        if (instance == null)
        {
            instance = new SoundManager();
        }
        return instance;
    }

    /**
     * @brief BGMの音源のゲッター
     * @return BGMの音源
     */
    public AudioClip GetBgmClip()
    {
        return bgmClip;
    }

    /**
     * @brief BGMの音量のセッター
     * @param[out] volume 音量
     */
    public void SetBgmVolume(float volume)
    {
        bgmSource.volume = volume;
    }

    /**
     * @brief BGMの再生
     * @param[out] checked チェックされているか
     */
    public void PlayBgm(bool isChecked)
    {
        if (isChecked)
        {
            bgmSource.mute = false;
        }
        else
        {
            bgmSource.mute = true;
        }
    }

    /**
     * @brief SEの音量のセッター
     * @param[out] volume 音量
     */
    public void SetSeVolume(float volume)
    {
        seSource.volume = volume;
    }

    /**
     * @brief SEの再生
     */
    public void PlaySe()
    {
        seSource.PlayOneShot(seClip);
    }
}
