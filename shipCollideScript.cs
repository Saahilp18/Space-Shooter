using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class shipCollideScript : MonoBehaviour
{
    public GameObject explosion;
    float sum = 0;
    bool end;
    // Start is called before the first frame update
    void Start()
    {
        end = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (end)
        {
            if (sum >= 2f)
            {
                EditorApplication.isPlaying = false;
            }
            else
                sum += Time.deltaTime;
        }

    }

    public void OnCollisionEnter(Collision collision)
    {
        Application.Quit();
        Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x - 35f, gameObject.transform.position.y, gameObject.transform.position.z);
        end = true;
                
    }
}
