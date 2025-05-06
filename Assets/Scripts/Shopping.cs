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

    private void Update()
    {
        UICoins = UIupdate.text;
        newCoins = int.Parse(UICoins);
        shopCoins = newCoins;
    }

    public void BuyItem1()
    {
        if (shopCoins >= 10)
        {
            shopCoins -= 10;
            UIupdate.text = shopCoins.ToString();
            UIupdateShop.text = shopCoins.ToString();
            YesSound.Play();
        }
        else
        {
            Debug.Log("pooooooop");
            NoSound.Play();
        }
    }
}
