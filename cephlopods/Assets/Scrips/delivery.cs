using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delivery : MonoBehaviour {

    public float speed;
    public GameObject[] targets;
	// Use this for initialization
	void Start () {
        //speed = 2f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        //  transform.Translate(speed * Time.deltaTime, 0, 0);

        //if (transform.position.x > 16)
        // {
        //     transform.position = transform.Translate(-speed * Time.deltaTime,01,0) ;//transform.Translate(-speed * Time.deltaTime, 0, 0);
        // }
        for (int i = 0; i < targets.Length; i++)
        {
            //so long as the enemy is not past the rightmost position on the board (3), move them by 0.2 per frame
            if (targets[i].transform.position.x < 17)
            {
                targets[i].transform.position += new Vector3(.1f, 0, 0);
            }
            else
            {
                targets[i].transform.position = new Vector3(13, targets[i].transform.position.y, targets[i].transform.position.z);
            }
      
    }
}
}
