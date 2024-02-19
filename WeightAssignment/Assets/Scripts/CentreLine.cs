using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentreLine : MonoBehaviour
{
    private GameObject Player;
    public AudioSource Footsteps;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(0, 3, Player.transform.position.z);
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
            Debug.Log("Safety");
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
            Debug.Log("Play that thing");
            Footsteps.Play();
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
            Debug.Log("Danger");
            Footsteps.Stop();
        }
    }
}
