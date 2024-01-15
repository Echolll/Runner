using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    [SerializeField] private Transform player;
    public GameObject[] roadPrefab;
    private List <GameObject> roadList = new List <GameObject>();
    private float spawnPose = 0;
    private float roadLenght = 50;
    private int startRoads = 6;

  
    void Start()
    {
        for (int i = 0; i < startRoads; i++)
        {
            SpawnRoad(Random.Range(0, roadPrefab.Length));
        }
    }

   
    void Update()
    {
        if(player.position.z - 50 > spawnPose - (startRoads * roadLenght)) 
        {
          SpawnRoad(Random.Range(0,roadPrefab.Length));
          DeleteRoad();
        }
  
    }

    private void SpawnRoad(int roadInedex)
    {
        GameObject nextRoad = Instantiate(roadPrefab[roadInedex],transform.forward * spawnPose, transform.rotation);
        roadList.Add(nextRoad);
        spawnPose += roadLenght;
    }

    private void DeleteRoad()
    {
        Destroy(roadList[0]);
        roadList.RemoveAt(0);   
    }

}

