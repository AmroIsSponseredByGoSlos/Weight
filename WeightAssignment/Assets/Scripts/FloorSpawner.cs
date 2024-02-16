using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    public GameObject Floor;
    public GameObject PreviousFloor;
    private Vector3 SpawnLocation;
    private GameObject LastSpawned;
    public GameObject FloorParent;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnFloor());
    }

    // Update is called once per frame
    void Update()
    {
        SpawnLocation = new Vector3(PreviousFloor.transform.position.x, PreviousFloor.transform.position.y, PreviousFloor.transform.position.z + 28);
    }

    IEnumerator SpawnFloor()
    {
        yield return new WaitForSeconds(3.5f);
        Quaternion rotation = Quaternion.Euler(0, 90, 90);
        LastSpawned = Instantiate(Floor, SpawnLocation, rotation, FloorParent.transform);
        PreviousFloor = LastSpawned; 
        StartCoroutine(SpawnFloor());
    }
}
