using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindSpawner : MonoBehaviour
{
    public GameObject Wind;
    public Vector3 SpawnLocation;
    public GameObject Player;
    public GameObject Parent;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        StartCoroutine(SpawnWind());
    }

    // Update is called once per frame
    void Update()
    {
        SpawnLocation = new Vector3(0, 250, Player.transform.position.z + 800);
    }

    IEnumerator SpawnWind()
    {
        yield return new WaitForSeconds(6f);
        Quaternion Rotation = Quaternion.Euler(0, 90, 0);
        Instantiate(Wind, SpawnLocation, Rotation, Parent.transform);
        StartCoroutine(SpawnWind());
    }
}
