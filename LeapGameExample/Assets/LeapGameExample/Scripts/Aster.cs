using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aster : MonoBehaviour
{
    public GameObject hitSound;
    public Manager gameManager;
    Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(0, 0, Random.Range(-1f, -6f));
        rigidbody.angularVelocity = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1));
    }

    private void Update()
    {
        if (transform.position.z < 0)
        {
            gameManager.OnHit();
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Shoot")
        {
            Instantiate(hitSound, transform.position, Quaternion.identity);
            gameManager.OnScore();
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
