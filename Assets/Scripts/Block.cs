using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    public float strenght=0.1f; //from 0.1f
    // Start is called before the first frame update
    void Start()
    {
        //if (GetComponent<FixedJoint2D>() != null && GetComponentInParent<Rigidbody2D>() != null)
        //    GetComponent<FixedJoint2D>().connectedBody = gameObject.get
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(Vector3.Magnitude(GetComponent<Rigidbody2D>().velocity + collision.rigidbody.velocity));

        if (Vector3.Magnitude(GetComponent<Rigidbody2D>().velocity+collision.rigidbody.velocity) > strenght)
            Unchained();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Dinamite")) {
            Vector2 target = transform.position - collision.transform.position;
            //target *= (collision.GetComponent<Dinamite>().Radius-Vector2.Distance(transform.position, collision.transform.position));
            Unchained();
            Detonate(target*collision.GetComponent<Dinamite>().Power);
        }
    }

    public void Unchained()
    {
        if (GetComponent<FixedJoint2D>() != null)
        {
            var joints=GetComponents<FixedJoint2D>();
            foreach (var l in joints)
                l.enabled = false;
        }
    }
    public void Detonate(Vector2 target)
    {
        GetComponent<Rigidbody2D>().AddForce(target);
        Debug.Log(target);
    }
    private void OnMouseUp()
    {
        FindObjectOfType<Utils>().Install(transform.position);
    }
}
