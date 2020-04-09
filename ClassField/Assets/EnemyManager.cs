using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [Header("怪物1號")]
    public Enemy Monster1;

    [Header("怪物2號")]
    public Enemy Monster2;

    private void Start()
    {
        //不小心多打了，就不刪了
        print("怪物1的血量:"+Monster1.hp
            + "怪物1的魔力:" + Monster1.mp
            + "怪物1的移動速度:" + Monster1.speed
            + "怪物1攻擊力:" + Monster1.atk
            + "怪物1防禦力:" + Monster1.def
            + "怪物1武器:" + Monster1.weapon
            + "怪物1裝備:" + Monster1.armor
            + "怪物1鑰匙:" + Monster1.key);
        print("怪物2的血量:" + Monster2.hp
            + "怪物2的魔力:" + Monster2.mp
            + "怪物2的移動速度:" + Monster2.speed
            + "怪物2攻擊力:" + Monster2.atk
            + "怪物2防禦力:" + Monster2.def
            + "怪物2武器:" + Monster2.weapon
            + "怪物2裝備:" + Monster2.armor
            + "怪物2鑰匙:" + Monster2.key);

        Monster1.hp = 100;
        Monster2.hp = 300;
        Monster1.def = 50;
        Monster1.weapon = "木棍";
        Monster2.weapon = "短刀";
        Monster1.key = true;
        Monster2.treasure = true;


    }
}
