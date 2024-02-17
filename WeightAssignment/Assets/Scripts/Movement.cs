using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject Player;
    private Rigidbody PlayerRb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        PlayerRb = Player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (PlayerRb.velocity.z < 8f)
        {
            PlayerRb.AddForce(0, 0, 33);
        }
        float HorizontalInput = Input.GetAxis("Horizontal");
        PlayerRb.AddForce(HorizontalInput * speed, 0, 0);
    }
}
