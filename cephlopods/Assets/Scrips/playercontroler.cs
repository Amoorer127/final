using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    public float mSpeed;
    public GameObject spy;
    Vector3 spyOrigin;
    public GameObject enemies;
    // Use this for initialization
    void Start()
    {
        spyOrigin = spy.transform.position;
        // mSpeed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(mSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, mSpeed * Input.GetAxis("Vertical") * Time.deltaTime);

        // if (Input.GetKeyDown(KeyCode.A))
        //{
        //  spy.transform.position += new Vector3 (0, 0, 1);
        //   }
        //if (Input.GetKeyDown(KeyCode.D))
        //  {
        //    spy.transform.position += new Vector3(0, 0, -1);
        // }
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //  spy.transform.position += new Vector3(1, 0, 0);
        //}
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //  spy.transform.position += new Vector3(-1, 0, 0);
        //}


        if (spy.transform.position.z < -5 ||
            spy.transform.position.x < 10.5 ||
          spy.transform.position.x > 18.4 ||
            spy.transform.position.y < -5)
        {
            spy.transform.position = spyOrigin;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            spy.transform.position = spyOrigin;
        }
            

    }

    //void OnCollisionEnter(Collision col){

    //	if (col.gameObject.name == "Shrimp") {

    //	spy.transform.postion = spyOrigin;
    //}
    //	}


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy"))

        {
           spy.transform.position = spyOrigin;
        }
        //other.gameObject.SetActive(false);
        //  count = count + 1;
        // SetCountText();
        //	}
        // }

        // private void OnCollisionEnter(Collision collision)
        // {
        //   if ()
        // }
    }
}
