// <auto-generated />
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(SignLanguageContext))]
    partial class SignLanguageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "6.0.0-preview.5.21301.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Infrastructure.Persistance.SignLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Word")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WordVideoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SignLanguages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Word = "abandon",
                            WordVideoUrl = "http://dlmg.ro/wp-content/uploads/2017/08/abandon-2.mp4"
                        },
                        new
                        {
                            Id = 2,
                            Word = "accepta",
                            WordVideoUrl = "http://dlmg.ro/wp-content/uploads/2017/06/accepta.mp4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
