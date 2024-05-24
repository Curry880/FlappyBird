using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public GameObject wall;
    public float spawnTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnWall());
    }

    private IEnumerator SpawnWall()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            float y = Random.Range(-500, 500);
            Instantiate(wall, new Vector3(10, y / 100, 0), Quaternion.identity);
        }
    }
}
