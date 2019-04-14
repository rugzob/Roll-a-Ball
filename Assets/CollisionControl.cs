using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControl : MonoBehaviour {

	void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Engel")
        {
            gameObject.SetActive(false);
            FindObjectOfType<GameManager>().Gameover();
        }
        
    }
}
