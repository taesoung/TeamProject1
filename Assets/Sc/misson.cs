using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class misson : MonoBehaviour
{
    [SerializeField] Toggle[] missonS = new Toggle[3];
    [SerializeField] Text[] textS = new Text[3];
    public int[] num = new int[3];
    public bool[] gold = new bool[3];
    public stat stat;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i<3;i++) {
            missonS[i].isOn = false;
            num[i] = 0;
            gold[i] = false;
        }
        stat = this.gameObject.GetComponent<stat>();
    }

    // Update is called once per frame
    void Update()
    {

        if (num[0] < 2)
        {
            missonS[0].isOn = false;
            textS[0].text = "던전 클리어(" + num[0] + "/2)";
        }
        else
        {
            missonS[0].isOn = true;
            if (gold[0] == false)
            {
                textS[0].text = "던전 클리어(2/2)";
                gold[0] = true;
                stat.getDiamond(1000);
            }
        }
        if (num[1] < 5)
        {
            missonS[1].isOn = false;
            textS[1].text = "무기 업그레이드(" + num[1] + "/5)";
        }
        else
        {
            missonS[1].isOn = true;
            if (gold[1] == false)
            {
                textS[1].text = "무기 업그레이드(5/5)";
                gold[1] = true;
                stat.getDiamond(300);
            }
        }
        if (num[2] < 5)
        {
            missonS[2].isOn = false;
            textS[2].text = "몬스터 처치(" + num[2] + "/5)";
        }
        else
        {
            missonS[2].isOn = true;
            if (gold[2] == false)
            {
                textS[2].text = "몬스터 처치(5/5)";
                gold[2] = true;
                stat.getDiamond(100);
            }
        }

    }
    

    public void numPlus(int i)
    {
        num[i]++;
    }














}
