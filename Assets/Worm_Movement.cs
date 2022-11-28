using System.Collections;
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
                    startPos = touch.position;
                    break;

                case TouchPhase.Moved:
                    direction = wormPos - touch.position;
                    direction.x = 0;

                    transform.position = direction;
                    break;

                case TouchPhase.Ended:

                    break;
            }
        }
    }
}
