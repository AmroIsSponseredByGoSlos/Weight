using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    private int Number;
    public AudioSource LeftWindSource;
    public AudioSource RightWindSource;

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
        if (Number == 1)
        {
            LeftWindSource.Play();
        }
        else
        {
            RightWindSource.Play();
        }
    }

    void OnTriggerStay(Collider col)
    {
        Rigidbody RB = col.gameObject.GetComponent<Rigidbody>();
        if (Number == 1)
        {
            RB.AddForce(400, 0, 0);
        }
        else
        {
            RB.AddForce(-400, 0, 0);
        }
    }

    void OnTriggerExit(Collider col)
    {
        LeftWindSource.Stop();
        RightWindSource.Stop();
    }
}
