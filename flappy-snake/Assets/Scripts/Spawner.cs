using UnityEngine;

public abstract class Spawner : MonoBehaviour
{
    [SerializeField] private float _minSpawnTime;
    [SerializeField] private float _maxSpawnTime;

    [SerializeField] protected Transform _target;
    [SerializeField] protected float _spawnXOffset;

    private float _currentDelay = 0;
    private float _lastTimeSpawned;

    private void Update()
    {
        if (_lastTimeSpawned + _currentDelay < Time.time)
        {
            _lastTimeSpawned = Time.time;
            _currentDelay = Random.Range(_minSpawnTime, _maxSpawnTime);
            Spawn();
        }
    }

    protected abstract void Spawn();
}