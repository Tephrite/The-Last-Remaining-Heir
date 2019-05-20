using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour
{

    CodeLock codeLock;
    int reachRange = 100;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            CheckHitObj();
        }
    }

    void CheckHitObj()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, reachRange))
        {
            codeLock = hit.transform.gameObject.GetComponentInParent <CodeLock>();

            if(codeLock != null)
            {
                string value = hit.transform.name;
                Debug.Log(value);
                codeLock.SetValue(value);
            }
        }
    }
}
