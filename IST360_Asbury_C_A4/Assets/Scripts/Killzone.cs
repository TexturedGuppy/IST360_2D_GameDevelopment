using UnityEngine;
using System.Collections;

public class Killzone : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        GameObject go = col.gameObject;
        Debug.Log("Collision");
        //Destroy(col.gameObject);
        DestroyObject(go);
    }
   
}
