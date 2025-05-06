using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporting : MonoBehaviour
{
    public Transform Player, dest;
    public GameObject PlayerG;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            PlayerG.SetActive(false);
            Player.position = dest.position;
            PlayerG.SetActive(true);
        }
    }
}
