using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public Text MoneyText;
    public int Money = 0;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //添加金钱
    public void AddMoney(int money)
    {
        Money += money;
        //  刷新金钱文本
        MoneyText.text = Money + "";//转成文本
    }
    //获得当前金钱
    public int GetMoney()
    {
        return Money;
    }
}
