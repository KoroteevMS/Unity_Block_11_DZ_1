using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _direction;

    private void Update()
    {
        transform.rotation = Quaternion.LookRotation(_direction);
        transform.Translate(_direction * _speed * Time.deltaTime, Space.World);
    }

    public void SetDirection(Vector3 direction)
    {
        _direction = direction;
    }
}