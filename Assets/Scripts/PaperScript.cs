using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperScript : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private int rotationChange;

    private Vector3 newTarget;
    private bool flag;

    private void Start()
    {
        newTarget.y = target.localPosition.y;
        newTarget.x = target.localPosition.x;
        newTarget.z = target.localPosition.z;
        newTarget.y -= rotationChange;

        flag = true;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {        
            transform.LookAt(newTarget);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (flag)
            {
               
                flag = false;
            }
        }
    }
}
