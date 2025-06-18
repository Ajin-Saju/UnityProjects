using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float maxtime = 2.5f;
    [SerializeField] private float heightRange = 0.45f;
    [SerializeField] private GameObject _pipe;

    private float _timer;

    private void Start()
    {
        SpawnPipe();
    }
    private void Update()
    {
        if (_timer > maxtime)
        {
            SpawnPipe();
            _timer = 0;
        }
        _timer += Time.deltaTime;
        
    }

    private void SpawnPipe()
    {
        Vector3 spawnpos = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange));
        GameObject pipe = Instantiate(_pipe, spawnpos, Quaternion.identity);

        Destroy(pipe, 10f);
    }
}
