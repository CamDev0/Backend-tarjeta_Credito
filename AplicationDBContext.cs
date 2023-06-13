using FBCreditCard.Models;
using Microsoft.EntityFrameworkCore;

namespace FBCreditCard
{
    //DbContext crea una instancia de la DB para almacenar datos, hacer querys, crear DB a partir del modelo, etc.
    public class AplicationDBContext:DbContext
    {
        //Mapeamos nuestro modelo con la base de datos con el DBset
        public DbSet<CreditCard> creditCard {  get; set; }

        //Constructor
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options): base(options) { }
    }
}
