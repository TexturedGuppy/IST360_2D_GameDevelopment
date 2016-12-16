using UnityEngine;
using System.Collections;

/// <summary>
/// Killzone script to attach to any killzone and it will destroy any objects that collide with it.
/// </summary>
public class Killzone : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

    /// <summary>
    /// Trigger Collider set up for the destruction
    /// </summary>
    /// <param name="col"></param>
    void OnTriggerEnter2D(Collider2D col)
    {
        GameObject go = col.gameObject;
        Debug.Log("Collision");
        //Destroy(col.gameObject);
        DestroyObject(go);
    }
   
}
