using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {

    [SerializeField] public GameManager gameManager;
    
	void onTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
	
}
