namespace CarRentalConsoleApp.Entities.Services {
    internal class BrazilTaxService : ITaxService{
        public double Tax(double amount) { 
            if (amount < 100.0) {
                return (amount * 0.20);
            } else {
                return (amount * 0.15);
            }
        }
    }
}
