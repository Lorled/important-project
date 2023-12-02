using UnityEngine;

public class CoinSpawner : Spawner
{
    [SerializeField] private CoinMovement _coin;
    [SerializeField] private float _yMaxSpawnPosition;
    [SerializeField] private float _yMinSpawnPosition;

    protected override void Spawn()
    {
        var spawnPosition = _target.position;
        spawnPosition.y = Random.Range(_yMinSpawnPosition, _yMaxSpawnPosition);
        spawnPosition.x += _spawnXOffset;
        CoinMovement coin = Instantiate(_coin, spawnPosition, _coin.transform.rotation);
        coin.Initialize(_target);
    }
}