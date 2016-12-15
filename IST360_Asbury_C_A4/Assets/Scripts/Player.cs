using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	//Consitant Updates instead of updates per frame
	void FixedUpdate () {
        movement();
        //Debug.Log("Working maybe?");
    }

    /// <summary>
    /// Controls Movement
    /// Normalizes Vectors so Diagonal movement stays the same
    /// </summary>
    void movement()
    {
        Vector3 translation = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.W))
            translation += new Vector3(0, .1f, 0);

        if (Input.GetKey(KeyCode.S))
            translation += new Vector3(0, -.1f, 0);

        if (Input.GetKey(KeyCode.A))
            translation += new Vector3(-.1f, 0, 0);

        if (Input.GetKey(KeyCode.D))
            translation += new Vector3(.1f, 0, 0);

        //Normalize "normalizes" the vectors all to the same value
        //This enables my player to travel diagonally at the correct speed
        translation.Normalize();
        translation *= speed;
        transform.position += translation;

    }
}
