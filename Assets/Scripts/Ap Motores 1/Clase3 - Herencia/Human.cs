

using UnityEngine;
using Villans;
using Heroes;
using MyEntities;
using System;

public class Test
{
    void Start()
    {
        Villans.Mage redMage = new Villans.Mage();
        Heroes.Mage whiteMage = new Heroes.Mage();



        //temas de Inteligencia artifical
        // Desition Tree
        // Behaviours trees
        // PathFinding
    }
}


public class Human : LifeEntity
{
    MercadoNegro.PartesDeCuerpo.Heart heart;

    public void Talk()
    {

    }

    public virtual void Walk()
    {
        Debug.Log("Walk normal 20 pies");
    }

    protected void _Jump()
    {
        Debug.Log("Salto por desicion del Humano");
    }
}

namespace Villans
{
    public class Mage
    {
        
    }
}


namespace Heroes
{
    using MercadoNegro.PartesDeCuerpo;

    public class Mage : Human, ICaster
    {
        public void CastHex()
        {

        }
    }
    public class Druid : Human, ICaster
    {
        void ICaster.CastHex()
        {

        }
    }
    public class Sorcerer : Human, ICaster
    {
        public void CastHex()
        {

        }
    }

    public class Paladin : Human, ICaster
    {
        public void CastHex()
        {

        }
    }

    
    public class Warrior : Human
    {
        protected string war_id;

        MercadoNegro.PartesDeCuerpo.Heart corz1; // Agregacion
        MercadoNegro.PartesDeCuerpo.Heart corz2;// Agregacion
        MercadoNegro.PartesDeCuerpo.Heart corz3;// Agregacion

        void Latir()
        {
            if (false)
            {
                firstheart.Latir();
            }
            else
            {
                corz1.Latir();
            }
        }


        public void JumpForOrders()
        {
            _Jump();
        }

        public override void Walk()
        {
            base.Walk();
            Debug.Log("Run rapido 30 pies");
        }

    }
    public class PsionicWarrior : Warrior, ICaster
    {
        private new string war_id;

        void ICaster.CastHex()
        {

        }

        void ShoutMyId()
        {
            Debug.Log("MI ID ES: " + war_id);
        }
    }

    public class SpecialWarrior : PsionicWarrior
    {
        void Shout()
        {

        }

    }
}


public interface ICaster
{
    public void CastHex();
}






namespace MercadoNegro.PartesDeCuerpo
{
    public class Heart
    {
        internal void Latir()
        {
            throw new NotImplementedException();
        }
    }
    public class Higado
    {

    }
    public class Rinones
    {

    }
}
namespace PartesDeLaCreacion
{
    public class Heart
    {
        internal void Latir()
        {
            throw new NotImplementedException();
        }
    }
    public class Higado
    {

    }
    public class Rinones
    {

    }
}


public class HeroBrain
{

}

namespace MyEntities // parte publica que vana  usar todos
{
    using MyEntities.Core;

    public class Monster : LifeEntity
    {
        public void Grunt()
        {

        }
    }

    public class LifeEntity : IDamageable
    {
        protected PartesDeLaCreacion.Heart firstheart; /// COMPOSICION
        public int vida;
        public int str;
        public int dex;
        public int con;
        public int intel;
        public int wis;
        public int chars;


        //public void TakeDamage(int dmg)
        //{
        //    vida -= dmg;
        //    if (vida >= 0) Death();
        //}

        void Death()
        {

        }

        void IDamageable.TakeDamage(int dmg)
        {
            vida -= dmg;
            if (vida >= 0) Death();
        }
    }


    


    public class Box : IDamageable
    {
        void IDamageable.TakeDamage(int dmg)
        {

        }
    }

}




namespace MyEntities.Core
{
    public interface IDamageable
    {
        public void TakeDamage(int dmg);
    }
}
