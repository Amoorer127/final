using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuttlefish : MonoBehaviour {
    public GameObject[] targets;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < targets.Length; i++)
        {
            //so long as the enemy is not past the rightmost position on the board (3), move them by 0.2 per frame
            if (targets[i].transform.position.y > 0)
            {
                targets[i].transform.position -= new Vector3(0, .2f, 0);
            }
            else
            {
                targets[i].transform.position = new Vector3(targets[i].transform.position.x, 13, targets[i].transform.position.z);
            }


        }
    }
}
