using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinCollecter : MonoBehaviour
{
    public int Coins = 0;
    public int newCoins;
    public string UICoins;
    public TextMeshProUGUI UIupdate;
    public TextMeshProUGUI UIupdateShop;
    public AudioSource CSound;

    private void Update()
    {
        UICoins = UIupdate.text;
        newCoins = int.Parse(UICoins);
        Coins = newCoins;
    }

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
