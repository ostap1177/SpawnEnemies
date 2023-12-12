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

    Vector3 _directionDestroyer;

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
                _directionDestroyer = new Vector3(_destroyer.transform.position.x - spawnPoint.position.x,
                    _destroyer.transform.position.y - spawnPoint.position.y,
                    _destroyer.transform.position.z - spawnPoint.position.z);  
                enemy.SetTargetDirection(_directionDestroyer);

                yield return waitForSeconds;
            }
        }
    }
}
