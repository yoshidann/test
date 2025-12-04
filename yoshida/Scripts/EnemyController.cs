using UnityEngine;

public class EnemyController : MonoBehaviour
{
    float Speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.Speed = 0.01f + 0.01f * Random.value;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Speed,0,0,Space.World);

        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < -10f)
        {
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
            Destroy(gameObject);
        }
    }
}
