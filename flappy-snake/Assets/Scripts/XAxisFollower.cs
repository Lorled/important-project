using UnityEngine;

public class XAxisFollower : MonoBehaviour
{
    [SerializeField] private Transform _followTarget;
    [SerializeField] private float _xPositionOffset = 6f;

    private void LateUpdate()
    {
        var newPosition = transform.position;
        newPosition.x = _followTarget.position.x + _xPositionOffset;
        transform.position = newPosition;
    }
}