using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    ObjectPooler objectPooler;

	// Use this for initialization
	void Start ()
    {
        objectPooler = ObjectPooler.Instance;
        IntermittentSpawn();
    }
	
    private void IntermittentSpawn()
    {
        InvokeRepeating("CubeSpawn", 1.0f, 4.0f);
    }

    private void CubeSpawn()
    {
        GameObject objectToSpawn = objectPooler.SpawnFromPool("Cube", transform.position, Quaternion.identity);
        objectToSpawn.SetActive(true);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
