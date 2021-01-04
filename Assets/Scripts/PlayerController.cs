using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CommonSpaceship spaceship;

    public float speed = 5;

    //public GameObject bullet;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        spaceship = GetComponent<CommonSpaceship>();

        while (true)
        {
            spaceship.Shot(transform);

            //Instantiate(bullet, transform.position, transform.rotation);

            yield return new WaitForSeconds(0.05f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");

        float y = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(x, y).normalized;

        //GetComponent<Rigidbody2D>().velocity = direction * speed;

        spaceship.Move(direction);
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "Enemy")
        {
            Destroy(c.gameObject);

            spaceship.Explosion();

            Destroy(gameObject);
        }
    }
}
