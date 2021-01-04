using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryExplosion : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnAnimationFinish()
    {
        Destroy(gameObject);
    }
}
