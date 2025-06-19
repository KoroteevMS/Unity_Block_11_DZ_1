using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _prefab;
    [SerializeField] private Target _target;

    public void Spawn()
    {
        Enemy enemy;

        enemy = Instantiate(_prefab, transform.position, Quaternion.identity);

        enemy.SetTarget(_target);
    }
}