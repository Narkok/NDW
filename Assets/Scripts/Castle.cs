using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Castle : MonoBehaviour
{
    [SerializeField] private int manaSpeed = 1;
    [SerializeField] private int maxMana = 100;
    private Transform spawnPoint;

    void Start()
    {
        spawnPoint = transform.Find("Spawn Point");
    }

    public void Spawn(Character.Type type)
    {
        Debug.Log(type);
    }
}