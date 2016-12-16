using UnityEngine;
using System.Collections;

/// <summary>
/// Single function for our fat stacks of cash to recognize when they have hit the player and get destroyed
/// Easily added into this function would be a score counter.
/// </summary>
public class MoneyStack : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /// <summary>
    /// More Trigger COlliders!
    /// Triggers are cool, and do things when you tell them
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
