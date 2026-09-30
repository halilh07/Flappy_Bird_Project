using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyGameObject;
    public float spawnInterval = 2f;
    public Transform spawnTransform;


    private void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    public IEnumerator SpawnObjects()
    {
        while (true)
        {
            Vector3 pos = spawnTransform.position;
            pos.y = Random.Range(-2f, 3f);
            Instantiate(enemyGameObject, pos, spawnTransform.rotation);
            yield return new WaitForSeconds(spawnInterval);
        }
    }

}
