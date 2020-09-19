using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombBird : Bird
{
    public GameObject explosion;

    public void OnCollisionEnter2D(Collision2D wood)
    {
        if (wood.gameObject.tag == "Obstacle")
        {
            Debug.Log("Bomb");
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(wood.gameObject);
            Destroy(this.gameObject);
        }
    }
}
