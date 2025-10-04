using UnityEngine;
using UnityEngine.SceneManagement;

public class DroneSpawn : MonoBehaviour

{
   public GameObject DronePrefab;
    float futureTime;
    int maxDrones = 10;
    int totalSpawn = 0;
    static public int AliveCurrentDrones = 0; 
    static public bool allDronesSpawn = false; 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        futureTime = Time.time + 1f;
    }

    // Update is called once per frame
    void Update()
    {
    if (AliveCurrentDrones < maxDrones && totalSpawn < maxDrones){
    
    Vector3 RandomSpawn = new Vector3(Random.Range(-6f, 6), Random.Range(-4f, 4f), 0);
     GameObject obj = Instantiate(DronePrefab);
     obj.transform.position = RandomSpawn;
     totalSpawn++;
     AliveCurrentDrones++;

    if(AliveCurrentDrones == maxDrones)
    {
        allDronesSpawn = true;
    }
    
    }
    
    }
}
