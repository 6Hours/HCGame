using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    Vector3 last;
    public float move;
    // Start is called before the first frame update
    void Start()
    {
        last = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        move = Vector3.Distance(transform.position, last);
        last = transform.position;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if(collision.gameObject.GetComponentInParent<Transform>()==GetComponentInParent<Transform>())
        //    GetComponent<FixedJoint2D>().enabled = false;

        if (!collision.gameObject.CompareTag(gameObject.tag)) GetComponent<FixedJoint2D>().enabled = false;
        
        //FixedJoint2D lm;
        //if (collision.gameObject.GetComponent<Block>().move != move)
        //{ TryGetComponent<FixedJoint2D>(out lm); lm.enabled = false;}
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
