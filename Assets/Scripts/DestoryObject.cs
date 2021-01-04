using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryObject : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D c)
    {
        if(c.gameObject.tag == "Enemy")
        {
            Destroy(c.gameObject);
        }
        else if(c.gameObject.tag == "PlayerBullet")
        {
            Destroy(c.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
