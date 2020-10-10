using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DragRotate : MonoBehaviour
{

    private Touch touch;
    private Vector2 touchposition;
    private Quaternion rotatey;
    private float rotSpeedMod = 0.1f;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved)
            {
                rotatey = Quaternion.Euler(0f, -touch.deltaPosition.x * rotSpeedMod, 0f);
                transform.rotation = rotatey * transform.rotation;
            }
        }
    }
    /*
    Vector3 mPrevPos = Vector3.zero;
    Vector3 mPosDelta = Vector3.zero;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mPosDelta = Input.mousePosition - mPrevPos;
            if (Vector3.Dot(transform.up, Vector3.up) >= 0)
            {
                transform.Rotate(transform.up, -Vector3.Dot(mPosDelta, Camera.main.transform.right), Space.Self);
            }
            else
            {
                transform.Rotate(transform.up, Vector3.Dot(mPosDelta, Camera.main.transform.right), Space.Self);
            }

            transform.Rotate(Camera.main.transform.right, Vector3.Dot(mPosDelta, Camera.main.transform.up), Space.Self);
        }

        mPrevPos = Input.mousePosition;
    }
    */
}
