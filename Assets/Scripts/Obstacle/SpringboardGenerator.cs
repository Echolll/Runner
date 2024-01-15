using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringboardGenerator : MonoBehaviour
{
    [SerializeField] private List<GameObject> _obstacles;
    [SerializeField] private Vector2 _borders;
    [SerializeField] private Vector2 _distanceBetweenObstacle;
    [SerializeField] private float _offset;
    [Range(1, 6), SerializeField] private int _obstacleAmount;
    [SerializeField] private Player _player;
    [SerializeField] private float _spawnTime;
    private float _elapsedTime;
    private float _prevPosition;

    private GameObject GetRandomObstacle()
    {
        return _obstacles[Random.Range(0, _obstacles.Count)];
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= _spawnTime)
        {
            _elapsedTime = 0;

            CreateObstacles(Random.Range(1, _obstacleAmount));

        }
    }

    private void CreateObstacles(int count)
    {
        if (count == 0)
        {
            return;
        }

        GameObject lastObstacle = null;

        for (int i = 0; i < count; i++)
        {

            var x = Random.Range(_borders.x, _borders.y);
            var z = Random.Range(_distanceBetweenObstacle.x, _distanceBetweenObstacle.y) + _offset + _prevPosition + _player.transform.position.z;
            lastObstacle = Instantiate(GetRandomObstacle(), new Vector3(x, 1, z), Quaternion.Euler(-30,0,0));
        }

        _prevPosition = lastObstacle.transform.position.z;
    }
}