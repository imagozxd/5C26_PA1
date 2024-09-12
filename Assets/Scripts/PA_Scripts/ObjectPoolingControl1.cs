using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolingControl1 : MonoBehaviour
{
    public List<GameObject> enemies;
    public List<GameObject> candies;
    public GameObject enemy;
    public GameObject candy;
    public int maxQuantity;

    public void GetObject()
    {
        if (enemies.Count > 0)
        {
            GameObject temp = enemies[0];
            enemies.Remove(temp);
            temp.SetActive(true);
            //
        }
        else
        {
            print("no hay mas");
        }
    }

    public void SetObject(GameObject obj)
    {
        enemies.Add(obj);
    }

}
