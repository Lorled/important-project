using UnityEngine;

public class CoinMovement : MonoBehaviour
{
    [SerializeField] private float _activationDistance = 5f;
    [SerializeField] private float _destroyDistance = 50f;
    [SerializeField] private float _speed = 2;

    private Transform _target;

    public void Initialize(Transform target)
    {
        _target = target;
    }

    private void Update()
    {
        if (Vector2.Distance(_target.transform.position, transform.position) < _activationDistance)
        {
            transform.position += (_target.transform.position - transform.position).normalized * _speed * Time.deltaTime;
        }

        if (Vector2.Distance(_target.transform.position, transform.position) > _destroyDistance)
        {
            Destroy(gameObject);
        }
    }
}