using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

    public GameObject moneySpawner; //Hook your fat stacks of money to this badboy to make it rain on that fairy.
    public float spawnTime; //Spawn time controller for ease of spawn time changes.

	// Use this for initialization
	void Start () {
        StartCoroutine(ObjectSpawner());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /// <summary>
    /// Co-Routine controlling the madness that is this money raining bonanza
    /// </summary>
    /// <returns></returns>
    IEnumerator ObjectSpawner()
    {
        while (true)
        {
                //Will instantiate objects at the spawners location
               GameObject go = (GameObject)Instantiate(moneySpawner, transform.position, transform.rotation);
               go.transform.position += new Vector3(Random.Range(-8.5f, 8.8f), 0); //Takes game object and spawns it at some random x position at the top of our little map
               yield return new WaitForSeconds(spawnTime);
        }
    }
}
