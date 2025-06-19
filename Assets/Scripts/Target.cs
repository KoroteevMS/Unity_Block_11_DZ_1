using UnityEngine;

[RequireComponent(typeof(Mover))]

public class Target : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;
    private Mover _mover;

    public void Awake()
    {
        _mover = GetComponent<Mover>();
    }

    private int _currentWeypoint = 0;

    private void Update()
    {
        if (transform.position == _waypoints[_currentWeypoint].position)
        {
            _currentWeypoint = (_currentWeypoint + 1) % _waypoints.Length;
        }

        _mover.Move(_waypoints[_currentWeypoint]);
    }
}