using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _prefab;
    [SerializeField] private float _delay;
    [SerializeField] private SpawnPoint[] _spawnPoints;

    private WaitForSeconds _wait;

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
        Enemy enemy;

        Vector3 spawnPosition = _spawnPoints[Random.Range(0, _spawnPoints.Length)].transform.position;
        enemy = Instantiate(_prefab, spawnPosition, Quaternion.identity);

        enemy.SetDirection(GenerateHorizontalDirection());
    }

    private Vector3 GenerateHorizontalDirection()
    {
        Vector3 randomDirection = new Vector3();

        while (randomDirection == Vector3.zero)
        {
            randomDirection = Random.insideUnitSphere;
            randomDirection.y = 0f;
        }
        
        return randomDirection.normalized;
    }
}