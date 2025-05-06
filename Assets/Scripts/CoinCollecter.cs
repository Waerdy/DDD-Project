using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCollecter : MonoBehaviour
{
    private int Coins = 0;
    public TextMeshProUGUI UIupdate;
    public TextMeshProUGUI UIupdateShop;
    public AudioSource CSound;

    private void OnTriggerEnter(Collider coinC)
    {
        if(coinC.transform.tag == "Coin")
        {
            Destroy(coinC.gameObject);
            Coins++;
            CSound.Play();
            UIupdate.text = Coins.ToString();
            UIupdateShop.text = Coins.ToString();
            Debug.Log("Coin pickup");
        }
    }
}
