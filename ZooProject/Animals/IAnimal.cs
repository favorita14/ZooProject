
namespace ZooProject.Animals
{
    public interface IAnimal
    {
        string Species { get; }
        int Health { get; set; }
        void ReduceHealth(int amount);
        bool IsAlive();
    }
}
