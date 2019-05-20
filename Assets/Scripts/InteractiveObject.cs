using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour {

	[SerializeField] private Vector3 openPosition, closePosition;
    [SerializeField] private float animationTime;
    [SerializeField] private MovementType movemenetType;
    [SerializeField] private bool isOpen = false;
    [SerializeField] private bool isLocked = false;
    [SerializeField] private Lock keyLock;
    [SerializeField] private bool hasLock;
    [SerializeField] private KeyCode inputKey;
    [SerializeField] private Animator anim = null;

    private Hashtable iTweenArgs;
    
    private enum MovementType { Slide, Rotate };

	// Use this for initialization
	void Start () {
        
        iTweenArgs = iTween.Hash();
        iTweenArgs.Add("position", openPosition);
        iTweenArgs.Add("time", animationTime);
        iTweenArgs.Add("isLocal", true);

    }


    public void PerformAction()
    {
        if(hasLock == true)
        {
            if (keyLock.getStatus() == false)
            {
                if (Input.GetKeyDown(inputKey) && anim.name == "bookcase (6)")
                {

                    if (isOpen)
                    {
                        iTweenArgs["position"] = closePosition;
                        iTweenArgs["rotation"] = closePosition;
                    }
                    else
                    {
                        iTweenArgs["position"] = openPosition;
                        iTweenArgs["rotation"] = openPosition;

                    }
                    isOpen = !isOpen;
                    Debug.Log("2");
                    if (movemenetType == MovementType.Slide)
                    {
                        iTween.MoveTo(gameObject, iTweenArgs);
                    }
                    else
                    {
                        iTween.RotateTo(gameObject, iTweenArgs);

                    }
                    anim.Play("BookCase");
                }

                else if (Input.GetKeyDown(inputKey))
                {
                    
                    if (isOpen)
                    {
                        iTweenArgs["position"] = closePosition;
                        iTweenArgs["rotation"] = closePosition;
                    }
                    else
                    {
                        iTweenArgs["position"] = openPosition;
                        iTweenArgs["rotation"] = openPosition;

                    }
                    isOpen = !isOpen;
                    Debug.Log("1");
                    if (movemenetType == MovementType.Slide)
                    {
                        iTween.MoveTo(gameObject, iTweenArgs);
                    }
                    else
                    {
                        iTween.RotateTo(gameObject, iTweenArgs);

                    }
                }
            }
        }
        else
        { 

            if (Input.GetKeyDown(inputKey))
            {
                if (isOpen)
                {
                    iTweenArgs["position"] = closePosition;
                    iTweenArgs["rotation"] = closePosition;
                }
                else
                {
                    iTweenArgs["position"] = openPosition;
                    iTweenArgs["rotation"] = openPosition;

                }
                isOpen = !isOpen;
                Debug.Log("3");
                if (movemenetType == MovementType.Slide)
                {
                    iTween.MoveTo(gameObject, iTweenArgs);
                }
                else
                {
                    iTween.RotateTo(gameObject, iTweenArgs);

                }
            }

            
        }
        
        
    }
}
