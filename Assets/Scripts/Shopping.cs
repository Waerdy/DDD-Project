using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shopping : MonoBehaviour
{
    public int shopCoins;
    public int newCoins;
    public string UICoins;
    public TextMeshProUGUI coinAmount;
    public TextMeshProUGUI UIupdate;
    public TextMeshProUGUI UIupdateShop;
    public AudioSource NoSound;
    public AudioSource YesSound;
    public bool isItBought1 = false;
    public bool isItBought2 = false;
    public bool isItBought3 = false;
    public TextMeshProUGUI purchaseButton1;
    public TextMeshProUGUI purchaseButton2;
    public TextMeshProUGUI purchaseButton3;

    private void Update()
    {
        UICoins = UIupdate.text;
        newCoins = int.Parse(UICoins);
        shopCoins = newCoins;
    }

    public void BuyItem1()
    {
        if (isItBought1 == true)
        {
            NoSound.Play();
        }
        if (shopCoins >= 10 && isItBought1 == false)
        {
            shopCoins -= 10;
            UIupdate.text = shopCoins.ToString();
            UIupdateShop.text = shopCoins.ToString();
            YesSound.Play();
            isItBought1 = true;
            purchaseButton1.text = "Already Purchased";
        }
        else
        {
            NoSound.Play();
        }
    }
    public void BuyItem2()
    {
        if (isItBought2 == true)
        {
            NoSound.Play();
        }
        if (shopCoins >= 15 && isItBought2 == false)
        {
            shopCoins -= 15;
            UIupdate.text = shopCoins.ToString();
            UIupdateShop.text = shopCoins.ToString();
            YesSound.Play();
            isItBought2 = true;
            purchaseButton2.text = "Already Purchased";
        }
        else
        {
            NoSound.Play();
        }
    }
    public void BuyItem3()
    {
        if (isItBought3 == true)
        {
            NoSound.Play();
        }
        if (shopCoins >= 5 && isItBought3 == false)
        {
            shopCoins -= 5;
            UIupdate.text = shopCoins.ToString();
            UIupdateShop.text = shopCoins.ToString();
            YesSound.Play();
            isItBought3 = true;
            purchaseButton3.text = "Already Purchased";
        }
        else
        {
            NoSound.Play();
        }
    }
}
