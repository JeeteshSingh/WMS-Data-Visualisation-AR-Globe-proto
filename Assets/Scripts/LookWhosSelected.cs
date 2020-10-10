using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;

public class LookWhosSelected : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        //if(Input.touchCount >0 && Input.touches[0].phase == TouchPhase.Began)
        {
            //Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                foreach(GameObject gameObj in GameObject.FindGameObjectsWithTag("CanBeSelected"))
                {
                    gameObj.transform.GetComponent<LeanPinchScale>().enabled=false;
                    
                }
                Hit.transform.GetComponentInChildren<LeanPinchScale>().enabled = true;
            }
        }
    }
}
