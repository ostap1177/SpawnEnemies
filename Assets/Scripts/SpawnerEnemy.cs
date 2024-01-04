using System.Collections;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    [SerializeField] private float _secondsWait;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Destroyer _destroyer;

    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    private void Start()
    {
        StartCoroutine(Create());
    }

    private IEnumerator Create()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(_secondsWait);

        while (true)
        {
            CreatEnrmy();

            yield return waitForSeconds;
        }
    }

    private void CreatEnrmy()
    {
        Enemy enemy = Instantiate(_enemy, _transform.position, Quaternion.identity);
        enemy.SetTarget(_destroyer.transform);
    }
}
