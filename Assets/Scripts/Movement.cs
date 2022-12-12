using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    [SerializeField] private GameObject worm;
    [SerializeField] private Slider slider;
    [SerializeField] private float movementSpeedPlayer;
    public int childs = 0;

    // Update is called once per frame
    void Update()
    {
        childs = this.transform.childCount;

        float movement = slider.value;

        worm.transform.position = new Vector2(0, movement);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Osuma!");
        if (collider.gameObject.tag == "Fish")
        {
            if (this.transform.childCount == 0)
            {
                collider.transform.parent = transform;
            }
        }
    }
}


