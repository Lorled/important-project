using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed = 5;
    [SerializeField] private float _maxAngle = 20;

    private Rigidbody2D _rigidbody;
    private float _currentAngle = 15;
    private bool _gameStarted = false;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (!_gameStarted)
        {
            return;
        }

        if ((Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0)) && _currentAngle < _maxAngle)
        {
            _currentAngle += _rotationSpeed;
        }
        else if (_currentAngle > -_maxAngle)
        {
            _currentAngle -= _rotationSpeed;
        }
        _rigidbody.MoveRotation(_currentAngle);

        _rigidbody.velocity = new Vector2(transform.right.x, transform.right.y) * _speed * Time.fixedDeltaTime;
    }

    private void StartGame()
    {
        _gameStarted = true;
    }

    private void OnEnable()
    {
        StartScreen.GameStarted += StartGame;
    }

    private void OnDisable()
    {
        StartScreen.GameStarted -= StartGame;
    }
}