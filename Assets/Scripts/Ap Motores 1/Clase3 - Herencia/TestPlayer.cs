using UnityEngine;
using MyEntities;
using MyEntities.Core;
using Heroes;

public class TestPlayer : MonoBehaviour
{
    private void Start()
    {

        Human commonHuman = new Human();
        commonHuman.Walk();

        Warrior warr = new Warrior();
        warr.Walk();

        warr.Talk();

        Box box = new Box();

        DoDamage(warr, 20);
        DoDamage(box, 20);
        

        warr.JumpForOrders();

        PsionicWarrior warr2 = new PsionicWarrior();

        warr.JumpForOrders();

        Mage mage = new Mage();
        mage.CastHex();

        Druid druid = new Druid();
        ((ICaster)druid).CastHex();
        //druid.CastHex();


        ICaster paladin = new Paladin();
        paladin.CastHex();


        ICaster[] casters = new ICaster[4];
        casters[0] = new Paladin();
        casters[1] = new Sorcerer();
        casters[2] = new Druid();
        casters[3] = new Mage();

        for (int i = 0; i < casters.Length; i++)
        {
            casters[i].CastHex();
        }




        


    }

    // Imaginense que esto es una Trampa de Pinchos
    public void DoDamage(IDamageable dmg , int quant)
    {
        dmg.TakeDamage(20);
    }
}
