using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveShip : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x > -10f && Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(Vector3.left * Time.deltaTime * 8f, Space.World);
            Vector3 rotateLeft = new Vector3(0, 0, -45f);
            if(gameObject.transform.rotation.z < .5f)
            transform.Rotate(rotateLeft * (-2f * Time.deltaTime));
        }

       else if (gameObject.transform.position.x < 10f && Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * 8f, Space.World);
            Vector3 rotateLeft = new Vector3(0, 0, 45f);
            if (gameObject.transform.rotation.z > -.5f)
                transform.Rotate(rotateLeft * (-2f * Time.deltaTime));
        }
        
       else
        {
            if(gameObject.transform.rotation.z > 0)
            {
                Vector3 rotateNormal = new Vector3(0, 0, -45f);
                transform.Rotate(rotateNormal * (2f * Time.deltaTime));
            }
            if (gameObject.transform.rotation.z < 0)
            {
                Vector3 rotateNormal = new Vector3(0, 0, 45f);
                transform.Rotate(rotateNormal * (2f * Time.deltaTime));
            }
        }

    }


}
