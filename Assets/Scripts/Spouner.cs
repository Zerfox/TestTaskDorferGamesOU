using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spouner : MonoBehaviour
{
    [SerializeField] private GameObject _whead;
    public List<Transform> ListPoints;
    private void Start()
    {
        int numberPointsForSpawn = GetComponent<Transform>().childCount;
        ListPoints = new List<Transform>(numberPointsForSpawn);

        for (int i = 0; i < numberPointsForSpawn; i++)
        {
            ListPoints.Add(transform.GetChild(i));
            spawnWhead(_whead, transform.GetChild(i));
        }
    }
    
    public void spawnWhead(GameObject gameObject, Transform point)
    {
        Instantiate(_whead, point.position, Quaternion.identity);
    }
}


