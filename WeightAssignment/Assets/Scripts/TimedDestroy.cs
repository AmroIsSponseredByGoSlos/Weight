using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestroy : MonoBehaviour
{
    public float Seconds = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Seconds > 0)
        {
            Seconds = Seconds - Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
