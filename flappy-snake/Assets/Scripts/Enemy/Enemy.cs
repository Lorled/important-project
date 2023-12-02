using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _moveDistance = 5;
    [Header("SpeedProperties")]
    [SerializeField] private float _minSpeed;
    [SerializeField] private float _maxSpeed;

    private float _minYPosition;
    private float _maxYPosition;
    private float _speed;
    private bool _isMovingUp;

    private void Start()
    {
        _speed = Random.Range(_minSpeed, _maxSpeed);
        _minYPosition = transform.position.y - _moveDistance;
        _maxYPosition = transform.position.y + _moveDistance;

        if (Random.Range(0, 2) == 1)
        {
            _isMovingUp = true;
        }
        else
        {
            _isMovingUp = false;
        }
    }

    private void Update()
    {
        var newPosition = transform.position;
        if (_isMovingUp)
        {
            if (transform.position.y > _maxYPosition)
            {
                ChangeDirection();
            }
            newPosition.y += _speed * Time.deltaTime;
        }
        else
        {
            if (transform.position.y < _minYPosition)
            {
                ChangeDirection();
            }
            newPosition.y -= _speed * Time.deltaTime;
        }
        transform.position = newPosition;
    }

    private void ChangeDirection()
    {
        _isMovingUp = !_isMovingUp;
    }
}