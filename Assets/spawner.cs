using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {
	 public List <GameObject> SpawnPrefab;
	public float TimeBetweenPlatforms = 10;
	public float MaxHeightofPlatform = 1;
	public float MinHeightofPlatform = -1;
	public float MaxLengthofPlatform = 6;
	public float MinLengthofPlatform = 4;
	float TimeSinceLastPlatform = 0;
	float TimeAccumulator = 0;

	// Use this for initialization
	void Start () {
		TimeSinceLastPlatform = TimeBetweenPlatforms;
	}

    // Update is called once per frame
    void Update()
    {
        TimeSinceLastPlatform += Time.deltaTime;
        TimeAccumulator += Time.deltaTime;
        if (TimeSinceLastPlatform > TimeBetweenPlatforms / ((TimeAccumulator / 60) + 1))
        {
            GameObject plat = Instantiate<GameObject>(SpawnPrefab[Random.Range(0, SpawnPrefab.Count)], transform.position + new Vector3(0, Mathf.Lerp(MinHeightofPlatform, MaxHeightofPlatform, Random.value), 0), transform.rotation);
            plat.transform.localScale = new Vector3(Mathf.Lerp(MinLengthofPlatform, MaxLengthofPlatform, Random.value), 1, 1);
            plat.GetComponent<platformMovement>().speed *= (TimeAccumulator / 60) + 1;
            TimeSinceLastPlatform = 0;
        }

    }
}
