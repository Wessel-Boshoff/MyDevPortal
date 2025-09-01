namespace AdoptionPortal.Models
{
    public class Adopter : Person
    {
        public List<Animal> AdoptedAnimals { get; } = [];

        public void Adopt(Animal animal)
        {
            AdoptedAnimals.Add(animal);
        }
    }
}
