using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Monster : MonoBehaviour
{

    private Dictionary<int, MonsterInfo> MonsterInfo = new Dictionary<int, MonsterInfo>();

    [SerializeField] int ID;

    [SerializeField] int HP;

    [SerializeField] int DiaDrop;


    [SerializeField] MonsterInfo[] MInfo;

    public Slider hpSlider; 

    // Start is called before the first frame update


    private void Awake()
    {
        foreach (MonsterInfo Info in MInfo)
        {
            MonsterInfo.Add(Info.MyID, Info);
        }
    }
    void Start()
    {
        SetProfile(Random.Range(0, 3));
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetProfile(int _monsterId)
    {
        foreach (KeyValuePair<int, MonsterInfo> _monsters in MonsterInfo)
        {
            if (_monsters.Key == _monsterId)
            {
                ID = _monsters.Value.MyID;
                DiaDrop = _monsters.Value.MyDiaDrop;

                hpSlider.maxValue = _monsters.Value.MyHP;
                hpSlider.value = _monsters.Value.MyHP;
            }
        }
    }
    public int HpDown(int num)
    {
        hpSlider.value -= num;
        if (hpSlider.value <= 0)
        {
            SetProfile(Random.Range(0, 3));
            return DiaDrop;
        }

        return 0;
    }
}
