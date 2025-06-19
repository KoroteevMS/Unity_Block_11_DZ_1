using UnityEngine;

[RequireComponent(typeof(Mover))]

public class Enemy : MonoBehaviour
{
    private Mover _mover;
    private Target _target;

    public void Awake()
    {
        _mover = GetComponent<Mover>();
    }

    private void Update()
    {
        _mover.Move(_target.transform);
    }

    public void SetTarget(Target target)
    {
        _target = target;
    }
}