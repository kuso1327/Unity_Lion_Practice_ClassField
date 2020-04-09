
using UnityEngine;

public class Enemy : MonoBehaviour
{   
    /// <summary>
    /// 怪物血量
    /// </summary>
    [Header("血量"),Tooltip("怪物的血量"),Range(50,500)]
    public int hp;
    /// <summary>
    /// 怪物魔力
    /// </summary>
    [Header("魔力"),Tooltip("怪物的魔力"),Range(10,100)]
    public int mp = 100;
    /// <summary>
    /// 怪物速度
    /// </summary>
    [Header("能力值"),Range(1,50.5F)]
    public float speed = 10.5f;
    /// <summary>
    /// 怪物攻擊力
    /// </summary>
    [Range(20,200)]
    public int atk = 50;
    /// <summary>
    /// 怪物防禦力
    /// </summary>
    [Range(0,100)]
    public int def;
    /// <summary>
    /// 怪物武器名稱
    /// </summary>
    [Header("裝備")]
    public string weapon;
    /// <summary>
    /// 怪物裝備名稱
    /// </summary>
    public string armor = "leather";
    /// <summary>
    /// 怪物是否帶鑰匙
    /// </summary>
    [Header("其他資料"),Tooltip("怪物是否帶有鑰匙")]
    public bool key = false;
    /// <summary>
    /// 怪物是否掉寶
    /// </summary>
    [Tooltip("怪物是否帶有寶物")]    
    public bool treasure = false;
    


}
