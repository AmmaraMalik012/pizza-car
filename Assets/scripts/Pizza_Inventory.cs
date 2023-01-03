using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Pizza_Inventory : MonoBehaviour
{
    public static Pizza_Inventory instance;
    public static Action<Transform> onPizzaDeleiver;
    public int pizzas;
    public TMPro.TextMeshProUGUI pizzaText;
    void Start()
    {
        onPizzaDeleiver += OnPizzaDeleiver;
    }
    private void OnPizzaDeleiver(Transform marker)
    {
        // showing pizza delivered UI
        Destroy(marker.gameObject);
        pizzas--;
        pizzaText.text = $"{pizzas}/3";
        if(pizzas == 0)
        {
            UIManager.instance.ShowWinScreen();
        }
        else
        {
            UIManager.instance.ShowDeleiverScreen();
        }
    }
}
