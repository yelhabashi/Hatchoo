using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{

    public GameObject enemy;
    private Player player;
    Vector3 enemyPos;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindObjectOfType<Player>();
        InvokeRepeating("SpawnEnemies", 2, 1);
    }

    void SpawnEnemies()
    {
        enemyPos = new Vector3(player.transform.position.x + 30, player.transform.position.y, 0f);
        Instantiate(enemy, enemyPos, Quaternion.identity);
    }
}
