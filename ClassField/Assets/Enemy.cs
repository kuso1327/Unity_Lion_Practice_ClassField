
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("血量"),Tooltip("怪物的血量")]
    public int hp = 100;
    public int mp = 100;
    public float speed = 10.5f;
    public int atk = 50;
    public int def = 10;
    public string weapon = "sword";
    public string armor = "leather";
    public bool key = false;
    public bool treasure = false;
    


}
