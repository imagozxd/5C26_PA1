using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    private Transform currenctPosition;
    private Transform newPosition;
    [SerializeField] private int value = 1;
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            Debug.Log(touchPosition);
            if (touch.phase == TouchPhase.Began)
            {
                if (touchPosition.y > 0)
                {
                    transform.position = new Vector2(transform.position.x, transform.position.y + value);
                    Debug.Log("up");

                }
                else
                {
                    transform.position = new Vector2(transform.position.x, transform.position.y - value);
                }
            }
        }
    }
}

