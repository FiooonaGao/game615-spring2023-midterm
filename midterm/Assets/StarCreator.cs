using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCreator : MonoBehaviour
{
    public GameObject star;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.V ))
        {
            for (int i = 0; i<100; i++)
            { GameObject StarCreator = Instantiate(star, gameObject.transform.position, Quaternion.identity);
                float rotXAmount = Random.Range(-89, -10);
                float rotYAmount = Random.Range(0, 360);
                StarCreator .transform.Rotate(rotXAmount, rotYAmount, 0);
                Rigidbody rb = StarCreator .GetComponent<Rigidbody>();
                rb.AddForce(StarCreator .transform.forward * 1000);

                Destroy(StarCreator, 5f);

            }
        }
    }
}
