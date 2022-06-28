using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class spawnEnemies : MonoBehaviour
{
    public GameObject bug;
    Rigidbody rb, newrb,rbb;
    float sum1 = 0;
    float sum2 = 0;
    Rigidbody[] rbArray;    // Start is called before the first frame update
    void Start()
    {
        rbArray = new Rigidbody[5];
        rb = bug.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(sum1 >= .6f)
        {
            Vector3 v = new Vector3(gameObject.transform.position.x + Random.Range(-10f, 10f), gameObject.transform.position.y, gameObject.transform.position.z);
            newrb = Instantiate(rb, v, gameObject.transform.rotation);
            sum1 = 0;
        }
        else
            sum1 += Time.deltaTime;
        */    
        if (sum2 >= 3f)
        {
            Vector3 v = new Vector3(gameObject.transform.position.x + Random.Range(-8f, 8f), gameObject.transform.position.y, gameObject.transform.position.z);
            Vector3 v1 = new Vector3(v.x-2f, v.y, v.z-2f);
            Vector3 v2 = new Vector3(v.x-1f, v.y, v.z-1f);
            Vector3 v3 = new Vector3(v.x, v.y, v.z);
            Vector3 v4 = new Vector3(v.x+1f, v.y, v.z-1f);
            Vector3 v5 = new Vector3(v.x+2f, v.y, v.z-2f);
            rbb = Instantiate(rb, v1, gameObject.transform.rotation);
            rbArray[0] = rbb;
            rbb = Instantiate(rb, v2, gameObject.transform.rotation);
            rbArray[1] = rbb;
            rbb = Instantiate(rb, v3, gameObject.transform.rotation);
            rbArray[2] = rbb;
            rbb = Instantiate(rb, v4, gameObject.transform.rotation);
            rbArray[3] = rbb;
            rbb = Instantiate(rb, v5, gameObject.transform.rotation);
            rbArray[4] = rbb;

            sum2 = 0;
        }
        else
            sum2 += Time.deltaTime;
            
    }

    public void FixedUpdate()
    {
        // if (newrb != null)
        //     newrb.AddForce(transform.forward * .2f, ForceMode.Impulse);

        for (int i = 0; i < 5; i++)
        {
            if(rbArray[i] != null)
            rbArray[i].AddForce(transform.forward * .025f, ForceMode.Impulse);
        }
            
    }
}
