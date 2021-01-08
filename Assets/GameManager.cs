using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    private int Cookie;
    private float Counter;
    public float Cooldown;
    public Text CookieText;
    public List<string> Names = new List<string>();
    public List<int> Numbers = new List<int>();
    public List<int> Costs = new List<int>();
    public List<int> Cooldowns = new List<int>();
    public List<int> Rates = new List<int>();
    private List<float> Counters = new List<float>() { 0, 0, 0 };
    public Text CookerButtonText;
    public Text OvensButtonText;
    public Text BakeryButtonText;

    void Start()
    {
        Cookie = 0;
        Counter = 0;
        //CookieText.text = "Cookies : 0";

        int result = 0;
        Debug.Log(result); // affiche résultat 

        /*for (int i=0;i<20;i++) // tant que I < 20 ajoute 1 
            {
            result = Increment(result); // appel de la fonction 
            }
            result = Add(result,5);*/
    }

    void Update()
    {
        Counter += Time.deltaTime;
        Counters[0] += Time.deltaTime;

        /*if (Counter>=Cooldown) 
        {
           Cookie = Increment(1);
            Counter -= Cooldown;

        }*/

        if (Counters[0] >= Cooldowns[0])
        {
            Cookie = Increment(Rates[0]);
            Counters[0] -= Cooldowns[0];
        }
    }

    public void ManuelIncrement()
    {
        Cookie = Increment(1);
    }

    public void BuyCooker()
    {
        Debug.Log("BuyCooker");
        if (Cookie >= Costs[0])
        {
            Cookie -= Costs[0];
            UpdateCookieDisplay(Cookie);
            Numbers[0]++;
            CookerButtonText.text = Names[0] + " : " + Numbers[0].ToString();
        }
    }

    private void UpdateCookieDisplay(int newNumber)
    {
        CookieText.text = "Cookies : " + newNumber.ToString();
    }

    public int Increment(int value) // la fonction avec sa définition 
    {
        int total = Cookie + value;
        UpdateCookieDisplay(total);
        //CookieText.text= "Cookies : " + total.ToString();
        return total;
    }

}