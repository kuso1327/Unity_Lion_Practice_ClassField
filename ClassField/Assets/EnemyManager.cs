using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [Header("怪物1號")]
    public Enemy Monster1;

    [Header("怪物2號")]
    public Enemy Monster2;

    private void Start()
    {
        print("怪物1的魔力:" + Monster1.mp);
        print("怪物2裝備:" + Monster2.armor);

        Monster1.hp = 100;
        Monster2.hp = 300;
        Monster1.def = 50;
        Monster1.weapon = "木棍";
        Monster2.weapon = "短刀";
        Monster1.key = true;
        Monster2.treasure = true;


    }
}
