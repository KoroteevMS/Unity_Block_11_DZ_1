using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    [SerializeField] private float _delay;
    [SerializeField] private SpawnPoint[] _spawnPoints;

    private WaitForSeconds _wait;
    private SpawnPoint _currentSpawnPoint;
    private Enemy _currentEnemy;

    private void Awake()
    {
        _wait = new WaitForSeconds(_delay);
    }

    private void Start()
    {
        StartCoroutine(SpawningRoutine());
    }

    private IEnumerator SpawningRoutine()
    {
        bool isWorking = true;

        while (isWorking)
        {
            Spawn();
            yield return _wait;
        }
    }

    private void Spawn()
    {
        _currentSpawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];

        _currentEnemy = Instantiate(_currentSpawnPoint.Prefab, _currentSpawnPoint.transform.position, Quaternion.identity);
        
        _currentEnemy.SetTarget(_currentSpawnPoint.Target);
    }
}