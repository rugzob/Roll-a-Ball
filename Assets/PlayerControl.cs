using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public Rigidbody rb;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {

        //ileri kodu
        rb.AddForce(0, 0, 600 * Time.deltaTime);

        //d ya basınca sağa gitme 
        if (Input.GetKey("d"))
        {
            rb.AddForce(600 * Time.deltaTime, 0, 0);
        }

        //a ya basınca sola gitme 
        if (Input.GetKey("a"))
        {
            rb.AddForce(-600 * Time.deltaTime, 0, 0);
        }

        if (Input.touchCount > 0)
        {
            //ekranın soluna dokunursa sola git
            if (Input.GetTouch(0).position.x < Screen.width/2)
            {
                rb.AddForce(-600 * Time.deltaTime, 0, 0);
            }

            //ekranın sağına dokunursa sağa git
            if (Input.GetTouch(0).position.x > Screen.width / 2)
            {
                rb.AddForce(600 * Time.deltaTime, 0, 0);
            }
        }


        if(transform.position.y <= -1)
        {
            //endgame
            FindObjectOfType<GameManager>().Gameover();
        }
    }
}
