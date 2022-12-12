using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] public GameObject fishPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(fishComing());
    }

    private void spawnFish()
    {
        GameObject fish = Instantiate(fishPrefab) as GameObject;
        fish.transform.position = new Vector2(-4, Random.Range(0, -4));
    }

    IEnumerator fishComing()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 3));
            spawnFish();
        }
       
    }
}
