using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    private Transform currenctPosition;
    private Transform newPosition;
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            Debug.Log(touchPosition);

            if (touchPosition.y > 0)
            {
                newPosition = currenctPosition.position.y +1f;
                Debug.Log("up");
            }
            else
            {

            }


        }
    }
}

