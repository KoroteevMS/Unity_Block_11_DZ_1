using UnityEngine;

public class Target : Mover
{
    [SerializeField] private Transform[] _waypoints;

    private int _currentWeypoint = 0;

    private void Update()
    {
        if (transform.position == _waypoints[_currentWeypoint].position)
        {
            _currentWeypoint = (_currentWeypoint + 1) % _waypoints.Length;
        }

        Move(_waypoints[_currentWeypoint]);
    }
}