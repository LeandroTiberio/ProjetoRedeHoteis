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
                        .HasOne(x => x.Estadias)                     
                        .WithMany(x => x.Hospedes)
                        .HasForeignKey(x => x.id_responsavel);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Hospede>().ToTable("hopedes");
            modelBuilder.Entity<Hospede>().HasKey(key => key.Id); //Indica a propriedade da chave primaria, no caso Id
            modelBuilder.Entity<Hospede>()
                        .HasOne(x => x.EstadiaXHospede)                     
                        .WithMany(x => x.Hospedes)
                        .HasForeignKey(x => x.id_Hospede);


            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EstadiaXHospede>().ToTable("Estadias_X_Hospedes");
            modelBuilder.Entity<EstadiaXHospede>().HasKey(key => key.Id); //Indica a propriedade da chave primaria, no caso Id
            modelBuilder.Entity<EstadiaXHospede>()
                        .HasOne(x => x.Estadias) //Indica a propriedade do relacionamento One = 1 Many = N
                        .HasOne(x => x.Estadia_X_Hospede)
                        .HasForeignKey(x => x.id_Estadia);


            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Hotel>().ToTable("hotel");
            modelBuilder.Entity<Hotel>().HasKey(key => key.Id); //Indica a propriedade da chave primaria, no caso Id
            modelBuilder.Entity<Hotel>()  
                        .HasMany(x => x.Quartos)
                        .WithMany(x =>x.Hotel)
                        .HasForeignKey(x => x.id_Hotel);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Quarto>().ToTable("quarto");
            modelBuilder.Entity<Quarto>().HasKey(key => key.Id); //Indica a propriedade da chave primaria, no caso Id
            modelBuilder.Entity<Quarto>()
                        .HasMany(X => X.TiposDeQuarto)
                        .WithMany(x =>x.Quarto)
                        .HasForeignKey(x => x.id_tipos_quartos);                             

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Estadia>().ToTable("estadias");
            modelBuilder.Entity<Estadia>().HasKey(key => key.Id); //Indica a propriedade da chave primaria, no caso Id
            modelBuilder.Entity<Estadia>()
                        .HasOne(x => x.Hospedes) //Indica a propriedade do relacionamento One = 1 Many = N
                        .WithOne(x => x.Quarto)
                        .HasForeignKey(x => x.id_quarto);

            
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TipoDeQuarto>().ToTable("TipoDeQuarto");
            modelBuilder.Entity<TipoDeQuarto>().HasKey(key => key.Id); //Indica a propriedade da chave primaria, no caso Id
                        .HasOne(x => x.Quarto) //Indica a propriedade do relacionamento One = 1 Many = N
                        .WithMany(x => x.TipoDeQuarto)
                        .HasForeignKey(x => x.id_tipos_quartos);
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Servico>().ToTable("Servico");
            modelBuilder.Entity<Servico>().HasKey(key => key.Id); //Indica a propriedade da chave primaria, no caso Id
                        .HasOne(x => x.Estadias) //Indica a propriedade do relacionamento One = 1 Many = N
                        .WithMany(x => x.Servico_X_Hoteis)
                        .HasForeignKey(x => x.id_Estadia);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ServicoXHotel>().ToTable("Servico_X_Hoteis");
            modelBuilder.Entity<ServicoXHotel>().HasKey(key => key.Id);
                        .HasOne(x => x.Hoteis) //Indica a propriedade do relacionamento One = 1 Many = N
                        .WithMany(x => x.Servico_X_Hoteis)
                        .HasForeignKey(x => x.id_Hotel);
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