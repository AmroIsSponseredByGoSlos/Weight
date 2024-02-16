using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    private int Number;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider col)
    {
        Number = Random.Range(1, 3);
    }

    void OnTriggerStay(Collider col)
    {
        Rigidbody RB = col.gameObject.GetComponent<Rigidbody>();
        if (Number == 1)
        {
            RB.AddForce(13, 0, 0);
        }
        else
        {
            RB.AddForce(-13, 0, 0);
        }
    }
}
