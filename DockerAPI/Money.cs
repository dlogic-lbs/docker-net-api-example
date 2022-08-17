namespace DockerAPI
{
    public class Money
    {
        // NOTE: Please understand that this `Money` class is just a quick money implementation and it is indeed a very basic one.
        // For the purpose of precise money transactions or even exchanging money between currencies a more sophisticated 
        // OOP representation of the business logic would have to be implemented (and properly tested).

        public Money(string SetCurrency, Double SetValue)
        {
            Currency = SetCurrency;
            Value = SetValue;
        }
        public string Currency { get; set; }

        public Double Value { get; set; }
    }
}
