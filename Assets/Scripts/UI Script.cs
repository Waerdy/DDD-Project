using UnityEngine;

public class UI_Script : MonoBehaviour
{
    public GameObject ShopUI;
    public GameObject MapUI;
    public GameObject InventoryUI;
    public GameObject PauseUI;

    public void ShopPress()
    {
        ShopUI.SetActive(false);
    }
    public void ShopEnterPress() 
    {
        ShopUI.SetActive(true);
    }
    public void MapEnterPress()
    {
        MapUI.SetActive(true);
    }
    public void MapPress()
    {
        MapUI.SetActive(false);
    }
    public void InventoryPress()
    {
        InventoryUI.SetActive(false);
    }
    public void InventoryEnterPress()
    {
        InventoryUI.SetActive(true);
    }
    public void PausePress()
    {
        PauseUI.SetActive(false);
    }
    public void PauseEnterPress()
    {
        PauseUI.SetActive(true);
    }
    public void GameExitPress()
    {
        Application.Quit();
    }

    public GameObject Sign1;
    public GameObject Sign2;
    public GameObject Sign3;
    public GameObject Sign4;
    public GameObject Sign5;
    public GameObject Sign6;

    public void Sign1ExitPress()
    {
        Sign1.SetActive(false);
    }
    public void Sign2ExitPress()
    {
        Sign2.SetActive(false);
    }
    public void Sign3ExitPress()
    {
        Sign3.SetActive(false);
    }
    public void Sign4ExitPress()
    {
        Sign4.SetActive(false);
    }
    public void Sign5ExitPress()
    {
        Sign5.SetActive(false);
    }
    public void Sign6ExitPress()
    {
        Sign6.SetActive(false);
    }
}
