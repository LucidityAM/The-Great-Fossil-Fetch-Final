﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Net;
using System.Numerics;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class Boss2 : MonoBehaviour
{
    public BattleSystemFossil battleSystemFossil;
    public UnitStats playerStats;

    public bool isDead;

    public CameraShake cameraShake;

    // Start is called before the first frame update
    void Start()
    {
        battleSystemFossil = GameObject.FindGameObjectWithTag("BattleSystem").GetComponent<BattleSystemFossil>();
        playerStats = GameObject.Find("Player (1)").GetComponent<UnitStats>();
        cameraShake = this.gameObject.GetComponent<CameraShake>();

        

    }// Grabs the BattleSystem script and assigns it to the empty variable battleSystemFossil, also sets enemy ID

    // Update is called once per frame
    void LateUpdate()
    {
        //Debug.Log(EnemyHolder.coroutinesRunning);
        if (EnemyHolder.bossNumber == 2 && battleSystemFossil.enemyLightingEffects[0] != null)
        {
            battleSystemFossil.enemyLightingEffects[0].SetActive(true);
        }
    }

    public IEnumerator BossTurn2()
    {

        if (battleSystemFossil.enemyLightingEffects[0] != null)
        {
            battleSystemFossil.enemyLightingEffects[0].SetActive(true);
            battleSystemFossil.currentEnemies[0].GetComponent<Image>().enabled = false;
        }
        //Sets all lighting effects for Panama

        if (battleSystemFossil.bossUnit[1].GetComponent<UnitStats>().currentHP < battleSystemFossil.bossUnit[1].GetComponent<UnitStats>().maxHP / 2)
        {
            isDead = playerStats.TakeDamage(battleSystemFossil.bossUnit[1].damage * 2);

            battleSystemFossil.playerColor.color = new Color(1, 0, 0);

            battleSystemFossil.CreatePlayerParticles();

            cameraShake.shake = battleSystemFossil.playerPrefab;
            EnemyHolder.shakeEnemy = true;

            battleSystemFossil.playerHUD.SetHP(battleSystemFossil.playerUnit.currentHP);

            yield return new WaitForSeconds(.2f);

            battleSystemFossil.playerColor.color = new Color(1, 1, 1);
            EnemyHolder.shakeEnemy = false;

            yield return new WaitForSeconds(.2f);

            battleSystemFossil.enemyLightingEffects[0].SetActive(false);

            yield return new WaitForSeconds(.55f);
        }
        else
        {
            isDead = playerStats.TakeDamage(battleSystemFossil.bossUnit[1].damage / PlayerStats.defendButton);

            battleSystemFossil.playerColor.color = new Color(1, 0, 0);

            battleSystemFossil.CreatePlayerParticles();

            cameraShake.shake = battleSystemFossil.playerPrefab;
            EnemyHolder.shakeEnemy = true;

            battleSystemFossil.playerHUD.SetHP(battleSystemFossil.playerUnit.currentHP);

            yield return new WaitForSeconds(.2f);

            battleSystemFossil.playerColor.color = new Color(1, 1, 1);
            EnemyHolder.shakeEnemy = false;

            yield return new WaitForSeconds(.2f);

            battleSystemFossil.enemyLightingEffects[0].SetActive(false);

            yield return new WaitForSeconds(.55f);

        }

        EnemyHolder.coroutinesRunning--;

        if (isDead)
        {

            battleSystemFossil.state = BattleStateFossil.LOST;
            battleSystemFossil.StartCoroutine("EndBattle");
            
        }
    } //Basic enemy turn that will look at which enemy the player is fighting, and start seperate scripts depending on the enemy.

}
