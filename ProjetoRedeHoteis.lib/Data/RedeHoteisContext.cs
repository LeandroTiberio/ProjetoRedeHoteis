using Microsoft.EntityFrameworkCore;
using ProjetoRedeHoteis.lib.Models;

namespace ProjetoRedeHoteis.lib.Data
{
    public class RedeHoteisContext : DbContext
    {
        public RedeHoteisContext(DbContextOptions options) : base (options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Hospede>().ToTable("hopedes");
            modelBuilder.Entity<Hospede>().HasKey(key => key.Id); //Indica a propriedade da chave primaria, no caso Id
            modelBuilder.Entity<Hospede>()
                        .HasOne(x => x.Estadia)                     
                        .WithMany(x => x.Hospedes)
                        .HasForeignKey(x => x.IdResponsavel);

            
            modelBuilder.Entity<Hospede>()
                        .HasMany(x => x.EstadiasXHospedes)                     
                        .WithOne(x => x.Hospede)
                        .HasForeignKey(x => x.IdHospede);


            modelBuilder.Entity<EstadiaXHospede>().ToTable("Estadias_X_Hospedes");
            modelBuilder.Entity<EstadiaXHospede>().HasKey(key => key.Id); //Indica a propriedade da chave primaria, no caso Id
            modelBuilder.Entity<EstadiaXHospede>()
                        .HasOne(x => x.Estadia) //Indica a propriedade do relacionamento One = 1 Many = N
                        .WithMany(x => x.EstadiasXHospedes)
                        .HasForeignKey(x => x.IdEstadia);


            modelBuilder.Entity<Hotel>().ToTable("hotel");
            modelBuilder.Entity<Hotel>().HasKey(key => key.Id); //Indica a propriedade da chave primaria, no caso Id
            modelBuilder.Entity<Hotel>()  
                        .HasMany(x => x.Quartos)
                        .WithOne(x =>x.Hotel)
                        .HasForeignKey(x => x.IdHotel);


            modelBuilder.Entity<Quarto>().ToTable("quarto");
            modelBuilder.Entity<Quarto>().HasKey(key => key.Id); //Indica a propriedade da chave primaria, no caso Id
            modelBuilder.Entity<Quarto>()
                        .HasOne(X => X.TipoDeQuarto)
                        .WithMany(x =>x.Quartos)
                        .HasForeignKey(x => x.IdTiposDeQuarto);                             

    
            modelBuilder.Entity<Estadia>().ToTable("estadias");
            modelBuilder.Entity<Estadia>().HasKey(key => key.Id); //Indica a propriedade da chave primaria, no caso Id
            modelBuilder.Entity<Estadia>()
                        .HasOne(x => x.Hospede) //Indica a propriedade do relacionamento One = 1 Many = N
                        .WithMany(x => x.Estadias)
                        .HasForeignKey(x => x.IdQuarto);

            
            modelBuilder.Entity<TipoDeQuarto>().ToTable("TipoDeQuarto");
            modelBuilder.Entity<TipoDeQuarto>().HasKey(key => key.Id);//Indica a propriedade da chave primaria, no caso Id
            modelBuilder.Entity<TipoDeQuarto>()
                        .HasOne(x => x.Quarto) //Indica a propriedade do relacionamento One = 1 Many = N
                        .WithMany(x => x.TiposDeQuartos)
                        .HasForeignKey(x => x.IdTiposDeQuarto);
            
        
            modelBuilder.Entity<Servico>().ToTable("Servico");
            modelBuilder.Entity<Servico>().HasKey(key => key.Id);//Indica a propriedade da chave primaria, no caso Id
           

            modelBuilder.Entity<ServicoXHotel>().ToTable("Servico_X_Hoteis");
            modelBuilder.Entity<ServicoXHotel>().HasKey(key => key.Id);
            modelBuilder.Entity<ServicoXHotel>()
                        .HasOne(x => x.Hotel) //Indica a propriedade do relacionamento One = 1 Many = N
                        .WithMany(x => x.ServicosXHotel)
                        .HasForeignKey(x => x.IdHotel);
        }

        public DbSet<Hospede> Hospedes { get; set; }
        public DbSet<Hotel> Hoteis { get; set; }
        public DbSet<TipoDeQuarto> TiposDeQuartos {get; set; }

        public DbSet<Quarto> Quartos { get; set; }
        public DbSet<Estadia> Estadias { get; set; }
        public DbSet<EstadiaXHospede> Estadias_X_Hospedes { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<ServicoXHotel> Servicos_X_Hoteis { get; set; }
    }
}