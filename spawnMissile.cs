using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnMissile : MonoBehaviour
{
    public GameObject missile;
     Rigidbody rb;
    Rigidbody newrb;

    // Start is called before the first frame update
    void Start()
    {
        rb = missile.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            newrb = GameObject.Instantiate(rb, gameObject.transform.position, gameObject.transform.rotation);
        }


    }
    public void FixedUpdate()
    {
        if(newrb != null)
        newrb.AddForce(transform.forward *2f, ForceMode.Impulse);
    }


}
