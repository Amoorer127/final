using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class proj2 : MonoBehaviour {
    public Text delivered;
    private int count;
    // Use this for initialization
    void Start () {

        count = 0;
        SetCountText();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("house"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        delivered.text = "Delivered: " + count.ToString();
        if (count >=4)
        {
            // winText.text = "You Win!";
        }
    }
}
