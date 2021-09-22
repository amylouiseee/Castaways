using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTranshShop : MonoBehaviour {



    public List<Transform> spawnArea = new List<Transform>();
    public static SpawnTranshShop instance = null;
    int index = 0;

    public GameObject[] prefab;

    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
            instance = this;
    }
    void Start()
    {
        SpawnRandomTrash();
    }

    void SpawnRandomTrash()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 pos = new Vector3(Random.Range(spawnArea[i].transform.position.x - 5, spawnArea[i].transform.position.x + 5), 100,
            Random.Range(spawnArea[i].transform.position.z - 5, spawnArea[i].transform.position.z + 5));

            GameObject Trash = GameObject.Instantiate(prefab[Random.Range(0,5)], pos, Quaternion.identity);
            Trash.transform.SetParent(spawnArea[index].transform);
        }
    }

}
