namespace PersonTests
{
    /// <summary>
    /// Represents one person saving their name.
    /// </summary>
    public class Person : IDisplayable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// Constructor for a person optionally adding their name.
        /// </summary>
        /// <param name="name">Person's name, empty by default.</param>
        public Person(string name = "", int size = 0, int reset = 0, int display = 0 )
        {
            this.Name = name.Trim();
            this.Sizes = size;
            this.Resets = reset;
            this.Displays = display;
        }

        /// <summary>
        /// Gets or sets the name of the person.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Returns a string that represents the person.
        /// </summary>
        /// <returns>String that represents the person.</returns>
        public override string ToString()
        {
            return this.Name;
        }

        
        public int Sizes { get; set; }

        public int Resets { get; set; }

        public int Displays { get; set; }

        int IDisplayable.Size() { return this.Sizes; }

        int IDisplayable.Reset() { return this.Resets; }

        int IDisplayable.Display() { return this.Displays; }

        



    }
}
