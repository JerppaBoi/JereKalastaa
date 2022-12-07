using System;
using System.Collections;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.UI;

public class Worm_Movement : MonoBehaviour
{
    public Vector2 startPos;
    public Vector2 direction;
    public Vector2 wormPos;

    // Update is called once per frame
    void Update()
    {
        wormPos = GameObject.Find("worm_hook_006").transform.position;



        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    // Record first touch in start position variable
                    Vector2 startPosition = Camera.main.ScreenToWorldPoint(touch.position);
                    startPos = startPosition;
                    break;

                case TouchPhase.Moved:
                    Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                    direction = wormPos - touchPosition;
                    direction.x = 0;

                    transform.position = direction;
                    break;

                case TouchPhase.Ended:

                    break;
            }
        }
    }
}
