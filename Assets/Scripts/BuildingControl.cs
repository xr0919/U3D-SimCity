using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingControl : MonoBehaviour
{
    //ÿ�����Ӷ��ٽ�Ǯ
    public int AddMoney = 100;
    //�����������Ԥ����
    public GameObject NewBuilding = null;
    //���������Ǯ
    public int NewBuildingPrice = 0;
    //��ʱ��
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
            //���ӽ�Ǯ
            UIManager.Instance.AddMoney(AddMoney);
        }
    }

    //���������
    private void OnMouseUpAsButton()
    {
        //Ŷ����������Ǯ�Ƿ��㹻
        if (UIManager.Instance.GetMoney() < NewBuildingPrice)
        {
            return;
        }
        //�ж��ܲ�������
        if(NewBuilding != null)
        {
            //�۳�������Ǯ
            UIManager.Instance.AddMoney(-NewBuildingPrice);
            //ʵ�����½�����
            Instantiate(NewBuilding, transform.position, transform.rotation);
            //ɾ����ǰ����
            Destroy(gameObject);

        }
    }

}
