using UnityEngine;

public class EnemySpawner : Spawner
{
    [SerializeField] private Enemy _prefab;

    protected override void Spawn()
    {
        var spawnPosition = _target.position;
        spawnPosition.y = 0;
        spawnPosition.x += _spawnXOffset;
        Instantiate(_prefab, spawnPosition, _prefab.transform.rotation);
    }
}