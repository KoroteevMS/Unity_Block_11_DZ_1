using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    public void Move(Transform targetTransfrom)
    {
        transform.LookAt(targetTransfrom);
        transform.position = Vector3.MoveTowards(transform.position, targetTransfrom.position, _speed * Time.deltaTime);
    }
}