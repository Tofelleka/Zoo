namespace Zoo
{
    internal class Animal
    {
        internal Animal(string name, Genders gender, string sound)
        {
            Name = name;
            Gender = gender;
            Sound = sound;
        }

        public string Name { get; private set; }
        public Genders Gender { get; private set; }
        public string Sound { get; private set; }
    }

    public enum Genders
    {
        Female = 0,
        Male = 1
    }
}
