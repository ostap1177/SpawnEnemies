using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerEnemies : MonoBehaviour
{
    [SerializeField] private float _secondsWait;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Destroyer _destroyer;

    [SerializeField] private Transform[] _spawnPoints;

    private void Start()
    {
        StartCoroutine(Create(_secondsWait));
    }

    private IEnumerator Create (float seconds)
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(seconds);

        while (true)
        {
            foreach (var spawnPoint in _spawnPoints)
            {
                Enemy enemy = Instantiate(_enemy, spawnPoint.position, Quaternion.identity);
                enemy.SetTarget(_destroyer.transform.position);

                yield return waitForSeconds;
            }
        }
    }
}
