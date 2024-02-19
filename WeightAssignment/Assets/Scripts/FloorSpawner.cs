using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    public GameObject Floor;
    private Vector3 SpawnLocation;
    public GameObject FloorParent;
    private int PlaceToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnFloor());
        PlaceToSpawn = 1450;
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnFloor()
    {
        yield return new WaitForSeconds(3.5f);
        SpawnLocation = new Vector3(0, -0, PlaceToSpawn);
        Quaternion rotation = Quaternion.Euler(0, 90, 90);
        Instantiate(Floor, SpawnLocation, rotation, FloorParent.transform);
        PlaceToSpawn = PlaceToSpawn + 1400;
        StartCoroutine(SpawnFloor());
    }
}
