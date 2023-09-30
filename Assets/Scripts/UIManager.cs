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
    //��ӽ�Ǯ
    public void AddMoney(int money)
    {
        Money += money;
        //  ˢ�½�Ǯ�ı�
        MoneyText.text = Money + "";//ת���ı�
    }
    //��õ�ǰ��Ǯ
    public int GetMoney()
    {
        return Money;
    }
}
