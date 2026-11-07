using UnityEngine;

public class Spawntest : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    public Vector3 spawnPosition;
    void Start()
    {
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
