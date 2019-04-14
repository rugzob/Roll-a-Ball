using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour {

	void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().CompleteLevel();
    }
}
