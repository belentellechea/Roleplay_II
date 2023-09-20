namespace RoleplayGame

{
    public interface IPersonaje 
    {
        int Health { get; }
        string Name { get; set; }
        int AttackValue{ get; }
        int DefenseValue{ get; }

        void Cure();
        void ReceiveAttack(int power);

    }
}