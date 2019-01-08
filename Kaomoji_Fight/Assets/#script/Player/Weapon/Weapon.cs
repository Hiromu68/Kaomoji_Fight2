﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

abstract public class Weapon : MonoBehaviour {

    protected Player owner_cs;              //オーナースクリプト
    protected PlaySceneManager PSManager_cs;//プレイシーンマネージャースクリプト

    protected GameObject Effect;            //エフェクト
    protected float EffectWait = 0.0f;      //エフェクトの発生している時間

    protected int DamgeValue = 0;           //ダメージ値

    protected virtual void Start()
    {
        PSManager_cs = GameObject.Find("PlaySceneManager").GetComponent<PlaySceneManager>();
    }

    public abstract void Attack();

    /// <summary>
    /// 渡された処理を指定時間後に実行する
    /// </summary>
    /// <param name="waitTime">遅延時間</param>
    /// <param name="action">実行する処理</param>
    /// <returns></returns>
    protected IEnumerator DelayMethod(float waitTime, Action action)
    {
        yield return new WaitForSeconds(waitTime);
        action();
    }

    public Player Owner_csData
    {
        set
        {
            owner_cs = value;
        }
    }

    public int DamageValue_Data
    {
        get
        {
            return DamgeValue;
        }
    }
}