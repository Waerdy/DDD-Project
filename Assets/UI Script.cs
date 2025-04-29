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
}
