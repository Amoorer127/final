using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrimpmovement : MonoBehaviour {
    public GameObject[] targets;
   // public GameObject player;
    //Vector3 spyOrigin;
    // Use this for initialization
    void Start () {
       // spyOrigin = player.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < targets.Length; i++)
        {
            //so long as the enemy is not past the rightmost position on the board (3), move them by 0.2 per frame
            if (targets[i].transform.position.x < 18)
            {
                targets[i].transform.position += new Vector3(.2f, 0, 0);
            }
            else
            {
                targets[i].transform.position = new Vector3(11, targets[i].transform.position.y, targets[i].transform.position.z);
            }

        
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
            //  count = count + 1;
            // SetCountText();
        }
    }

    //void OnCollisionEnter(Collision player)
    //{
    //}
}
