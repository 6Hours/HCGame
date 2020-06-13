using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinamite : MonoBehaviour
{
    public float Radius = 1f;
    public float Power = 200f;
    public Sprite Boom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Detonate()
    {
        GetComponent<CircleCollider2D>().enabled = true;
        GetComponent<CircleCollider2D>().radius = Radius;

        Destroy(gameObject,0.1f);
    }
}
