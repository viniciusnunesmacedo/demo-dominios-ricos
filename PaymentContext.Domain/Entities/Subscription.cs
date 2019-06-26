using System;
using System.Collections.Generic;
using Flunt.Validations;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Subscription : Entity{

        private IList<Payment> _payments;
        public Subscription(DateTime? expireDate)
        {
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            ExpireDate = expireDate;
            Active = true;
            Payments = new List<Payment>();;
        }

        public DateTime CreateDate  {get; private set;}
        public DateTime LastUpdateDate  {get; private set;}
        public DateTime? ExpireDate  {get;private set;}
        public bool Active {get; private set;}
        public IReadOnlyCollection<Payment> Payments {get; private set;}

        public void AddPayment(Payment payment){
            
            AddNotifications(new Contract()
                .Requires()
                .IsGreaterThan(DateTime.Now, payment.PaidDate, "Subscription.Payments","A data do pagamento deve ser futura")
            );
            
            _payments.Add(payment);
        }

        public void Activate(){
            Active = true;
            LastUpdateDate = DateTime.Now;
        }

        public void Desactivate(){
            Active = false;
            LastUpdateDate = DateTime.Now;
        }
    }
}