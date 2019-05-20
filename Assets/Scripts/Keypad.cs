using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : MonoBehaviour
{

    [SerializeField] private Vector3 openPosition, closePosition;
    [SerializeField] private float animationTime;


    private Hashtable iTweenArgs;
    CodeLock codeLock;

    // Use this for initialization
    void Start()
    {

        iTweenArgs = iTween.Hash();
        iTweenArgs.Add("position", openPosition);
        iTweenArgs.Add("time", animationTime);
        iTweenArgs.Add("isLocal", true);

    }


    public void PerformAction()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //codeLock = hit.transform.gameObject.GetComponentInParent<CodeLock>();

            if (codeLock != null)
            {
                //string value = hit.transform.name;
                //Debug.Log(value);
                //codeLock.SetValue(value);
            }
        }
    }
}