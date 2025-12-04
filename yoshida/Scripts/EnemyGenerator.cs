using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject EnemyPrefab;

    void Start()
    {
        InvokeRepeating("GeneEnem",1, 1);
    }

    void GeneEnem()
    {
        Instantiate(EnemyPrefab, new Vector3(30, -2.5f + 5 * Random.value, 0), Quaternion.identity);
    }
}
