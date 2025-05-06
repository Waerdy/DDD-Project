using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemUsage : MonoBehaviour
{
    public TextMeshProUGUI invItem1;
    public TextMeshProUGUI invItem2;
    public TextMeshProUGUI invItem3;
    [SerializeField] private GameObject hat;
    public AudioSource ISound;
    [SerializeField] private GameObject rooftp;
    [SerializeField] private GameObject floortp;

    void Start()
    {
        hat.SetActive(false);
        rooftp.SetActive(false);
        floortp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (invItem1.text == "Owned")
        {
            if (Input.GetKey(KeyCode.Q))
            {
                ISound.Play();
            }
        }
        if (invItem2.text == "Owned")
        {
            rooftp.SetActive(true);
            floortp.SetActive(true);
        }
        if (invItem3.text == "Owned")
        {
            hat.SetActive(true);
        }
    }
}
