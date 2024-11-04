using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [SerializeField]
    private EnemyController enemyPrefab;

    [SerializeField]
    private Transform enemySpawn;

    [SerializeField]
    private Transform enemyTarget;

    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            var enemy = Instantiate(enemyPrefab, enemySpawn.position, Quaternion.identity);
            enemy.SetDestination(enemyTarget.position);
        }
    }
}
