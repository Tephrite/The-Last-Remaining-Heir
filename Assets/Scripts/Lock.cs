using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour {

    [SerializeField] private bool isLocked = true;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Key")
        {
            isLocked = false;
            Destroy(other);
        }
    }

    public bool getStatus()
    {
        return isLocked;
    }
}
