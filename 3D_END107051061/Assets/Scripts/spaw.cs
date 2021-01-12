
using UnityEngine;

public class spaw : MonoBehaviour
{
    public GameObject spawn;
    public GameObject Bee;
    public void Spawn()
    {
        GameObject.Instantiate(Bee, spawn.transform.position, Quaternion.identity);
    }
    public void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Spawn();
        }
    }
}
