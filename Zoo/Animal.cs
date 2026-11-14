namespace Zoo
{
    internal class Animal
    {
        internal Animal(string name, Gender gender, string sound)
        {
            Name = name;
            Gender = gender;
            Sound = sound;
        }

        public string Name { get; private set; }
        public Gender Gender { get; private set; }
        public string Sound { get; private set; }
    }

    public enum Gender
    {
        Female = 0,
        Male = 1
    }
}
