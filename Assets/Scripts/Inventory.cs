using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    public TextMeshProUGUI invItem1;
    public TextMeshProUGUI invItem2;
    public TextMeshProUGUI invItem3;
    public TextMeshProUGUI purchaseButton1;
    public TextMeshProUGUI purchaseButton2;
    public TextMeshProUGUI purchaseButton3;

    private void Update()
    {
        if (purchaseButton1.text == "Already Purchased")
        {
            invItem1.text = "Owned";
        }
        if (purchaseButton2.text == "Already Purchased")
        {
            invItem2.text = "Owned";
        }
        if (purchaseButton3.text == "Already Purchased")
        {
            invItem3.text = "Owned";
        }
    }
}
