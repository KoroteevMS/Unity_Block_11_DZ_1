public class Enemy : Mover
{
    private Target _target;

    private void Update()
    {
        Move(_target.transform);
    }

    public void SetTarget(Target target)
    {
        _target = target;
    }
}