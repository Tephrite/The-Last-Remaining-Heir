using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour {

    [SerializeField] private float interactRange;

    private RaycastHit hit;
    private InteractiveObject obj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, interactRange);

            if (hit.transform)
            {
                obj = hit.transform.GetComponent<InteractiveObject>();
            }

            if (obj)
            {
                obj.PerformAction();
            }
            
        }
	}

}
