using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects{

    public class Name : ValueObject{
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(FirstName, 3, "Name.FirstName", "Nome deve ter pelo menos 3 catacteres")
                .HasMaxLen(FirstName, 40, "Name.FirstName", "Nome deve ter no máximo 40 catacteres")
                .HasMinLen(LastName, 3, "Name.LastName", "Sobrenome deve ter pelo menos 3 catacteres")
                .HasMaxLen(LastName, 40, "Name.LastName", "Sobrenome deve ter no máximo 40 catacteres")
            );
        
        }

        public string FirstName {get; private set;}
        public string LastName {get; private set;}

    }
}