using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    [SerializeField] private GameObject worm;
    [SerializeField] private Slider slider;
    [SerializeField] private float movementSpeedPlayer;

    // Update is called once per frame
    void Update()
    {
        float movement = slider.value;

        worm.transform.position = new Vector2(0, movement) * movementSpeedPlayer * Time.deltaTime;
    }
}
