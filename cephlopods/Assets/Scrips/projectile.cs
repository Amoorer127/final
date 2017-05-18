using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class projectile : MonoBehaviour {
    public float PSpeed;
    public GameObject player;
    public Renderer rend;
    GameObject prefab;


    public Text delivered;
    private int count;
    // Use this for initialization
    void Start () {
        prefab = Resources.Load("capsule") as GameObject;

        rend = GetComponent<Renderer>();

        count = 0;
       // SetCountText();
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            GameObject Projectile = Instantiate(prefab) as GameObject;
            Projectile.transform.position = transform.position + player.transform.forward * 2;

            Rigidbody rb = Projectile.GetComponent<Rigidbody>();

            rb.velocity = player.transform.forward * PSpeed;

           // Shoot.Play();
            
        }


	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            other.gameObject.SetActive(false);
           count = count + 1;
           // SetCountText();
        }
    }

    //void SetCountText()
    //{
     //   delivered.text = "Delivered: " + count.ToString();
     //   if (count >= 2)
       // {
           // winText.text = "You Win!";
      //  }
   // }

}
