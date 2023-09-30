using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingControl : MonoBehaviour
{
    //每秒增加多少金钱
    public int AddMoney = 100;
    //升级建筑物的预设体
    public GameObject NewBuilding = null;
    //升级所需金钱
    public int NewBuildingPrice = 0;
    //计时器
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            timer = 0;
            //增加金钱
            UIManager.Instance.AddMoney(AddMoney);
        }
    }

    //鼠标点击升级
    private void OnMouseUpAsButton()
    {
        //哦按段升级金钱是否足够
        if (UIManager.Instance.GetMoney() < NewBuildingPrice)
        {
            return;
        }
        //判断能不能升级
        if(NewBuilding != null)
        {
            //扣除升级金钱
            UIManager.Instance.AddMoney(-NewBuildingPrice);
            //实例化新建筑物
            Instantiate(NewBuilding, transform.position, transform.rotation);
            //删除当前建筑
            Destroy(gameObject);

        }
    }

}
