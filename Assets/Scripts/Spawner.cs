using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
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
        _spawnPoints[Random.Range(0, _spawnPoints.Length)].Spawn();
    }
}