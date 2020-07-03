using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVsEnemy : MonoBehaviour
{
    public GameObject myPlayer;
    PlayerStats playerStats;
    PlayerController playerController;

    EnemyStats enemyStats;
    EnemyController enemyController;



    // Start is called before the first frame update
    void Start()
    {
        playerStats = myPlayer.GetComponent<PlayerStats>();
        playerController = myPlayer.GetComponent<PlayerController>();
        enemyStats = GetComponent<EnemyStats>();
        enemyController = GetComponent<EnemyController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyController.getEnemyAttacking() && playerController.getPlayerAttackingEnemy()
            && enemyStats.HP > 0)
        {
            playerTakesDamage();
            enemyTakesDamage();
        }
        else if(enemyController.getEnemyAttacking() && enemyStats.HP > 0)
        {
            playerTakesDamage();
        }
    }

    void playerTakesDamage()
    {
        playerStats.HP -= enemyStats.damage * Time.deltaTime;
    }

    void enemyTakesDamage()
    {
        enemyStats.HP -= playerStats.damage * Time.deltaTime;
    }

}
