/**
 * 基本属性
 */
[System.Serializable]
public class Attributes {
  public float maxHp = 0;
  public float atk = 0;
  public float def = 0;
  public float magicResistance = 0;
  public int cost = 0;
  public int blockCnt = 0;
  public float moveSpeed = 1;
  public float attackSpeed = 100;
  public float baseAttackTime = 1;
  public float baseAttackForwardTime = 0;// 攻击前摇时间，攻击前摇时间必须小于攻击间隔，且与攻击间隔等比例变化
  public float baseSearchTime = 0;// 第一个敌人进入攻击范围时会有第一次抬手时间，固定，攻击范围内没有敌人时重置
  public float respawnTime = 0;
  public int maxDeployCount = 1;
  public int maxDeckStackCnt = 1;
  public float toughness = 0;//韧性，对所有负面效果起作用
  public float range = 20;//攻击距离
  public float ballisticSpeed = 1;// 弹道速度
  public int attackNum = 1;// 攻击个数
  public Attributes(float maxHp,float atk,float range){
    this.maxHp = maxHp;
    this.atk = atk;
    this.range = range;
  }
}