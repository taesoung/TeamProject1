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
    [SerializeField] int bossDiaDrop;


    [SerializeField] SpriteRenderer monsterImage;

    [SerializeField] MonsterInfo[] MInfo;

    [SerializeField] stat st;

    public GameObject hpSlider;
    public GameObject bosshpSlider;

    public bool boss;

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
                monsterImage.sprite = _monsters.Value.MymonsterImage;
                bosshpSlider.SetActive(false);
                hpSlider.SetActive(true);
                hpSlider.GetComponent<Slider>().maxValue = _monsters.Value.MyHP;
                hpSlider.GetComponent<Slider>().value = _monsters.Value.MyHP;
           
            }
        }
    }
    public void SetProfile2(int _monsterId,float n)
    {
        foreach (KeyValuePair<int, MonsterInfo> _monsters in MonsterInfo)
        {
            if (_monsters.Key == _monsterId)
            {
                ID = _monsters.Value.MyID;
                bossDiaDrop = _monsters.Value.MyDiaDrop* 100 * (int)n;
                monsterImage.sprite = _monsters.Value.MymonsterImage;
                bosshpSlider.SetActive(true);
                hpSlider.SetActive(false);
                bosshpSlider.GetComponent<Slider>().maxValue = _monsters.Value.MyHP *n*10.0f;
                bosshpSlider.GetComponent<Slider>().value = _monsters.Value.MyHP * n*10.0f;




                st.bossmonsterSet(this.gameObject);

            }
        }
    }
    public int HpDown(int num)
    {
        if (boss)
        {


            bosshpSlider.GetComponent<Slider>().value -= num;
            if (bosshpSlider.GetComponent<Slider>().value <= 0)
            {

                return bossDiaDrop;
            }

                return 0;
        }

        hpSlider.GetComponent<Slider>().value -= num;
        if (hpSlider.GetComponent<Slider>().value <= 0)
        {
          
            SetProfile(Random.Range(0, 3));

            return DiaDrop;
        }

        return 0;
    }
    public bool HPzero()
    {

        if (bosshpSlider.GetComponent<Slider>().value <= 0)
        {
            bosshpSlider.SetActive(false);
            hpSlider.SetActive(true);
            return true;
        }
        return false;

    }
    public int diaText()
    {
        return bossDiaDrop;
    }

}
