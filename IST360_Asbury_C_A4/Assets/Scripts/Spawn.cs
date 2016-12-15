using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

    public GameObject moneySpawner;
    public float spawnTime;

	// Use this for initialization
	void Start () {
        StartCoroutine(ObjectSpawner());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator ObjectSpawner()
    {
        while (true)
        {

            GameObject go = (GameObject)Instantiate(moneySpawner, transform.position, transform.rotation);
           go.transform.position += new Vector3(Random.Range(-8.5f, 8.8f), 0);
           yield return new WaitForSeconds(spawnTime);
        }
    }
}
