using UnityEngine;

public class BulletController : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.1f, 0, 0);

        if(transform.position.x > 10)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("Canvas").GetComponent<UIController>().AddScore();

        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
