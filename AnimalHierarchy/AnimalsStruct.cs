using AnimalHierarchy.Classes;

namespace AnimalHierarchy
{
    struct AnimalsStruct
    {
        public static Animal[] animals1 = new Animal[]
        {
                new Kitten("Piss Duta", 2),
                new Frog("Gelu", 3),
                new Frog("Marin", 2),
                new Tomcat("Gogu", 5),
                new Dog("Costel", 7),
                new Tomcat("Souzaki", 2),
                new Kitten("Ionela", 1),
                new Dog("Vasile", 3),

        };

        public static Animal[] animals2 = new Animal[]
        {
                new Dog("Lupu", 14),
                new Frog("Marian", 3),
                new Kitten("Vasilica", 6),
                new Tomcat("Mirel", 2),
                new Frog("Malaria", 1, Animal.Sex.Female),
                new Kitten("Elenus", 5),
                new Tomcat("Usturoi", 2)
        };

        public static Animal[] animals3 = new Animal[]
        {
                new Frog("Gicu Broscoiu", 3),
                new Kitten("Tabi", 2),
                new Frog("Geaneta Broscoaia", 2, Animal.Sex.Female),
                new Dog("Suier", 2),
                new Kitten("Alina", 16),
                new Tomcat("Nijalau", 5),
                new Tomcat("Pis Dutu", 1)
        };
    }
}
