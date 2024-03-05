using Microsoft.EntityFrameworkCore;
using Shared.DbModels;

namespace ValhallaVaultCyberAwareness.Data
{
    public class SecurityDbContext : DbContext
    {

        public SecurityDbContext(DbContextOptions<SecurityDbContext> options) : base(options)
        {

        }

        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<SegmentModel> Segments { get; set; }
        public DbSet<SubcategoryModel> Subcategories { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<AnswerModel> Answers { get; set; }
        public DbSet<UserResponseModel> UserResponses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelB)
        {
            SeedData(modelB);
        }

        private void SeedData(ModelBuilder modelB)
        {

            //Seedad Category
            modelB.Entity<CategoryModel>().HasData(

                new CategoryModel
                {
                    Id = 1,
                    Name = "Att skydda sig mot bedrägerier",
                },

                new CategoryModel
                {
                    Id = 1,
                    Name = "Cybersäkerhet för företag",
                },

                new CategoryModel
                {
                    Id = 1,
                    Name = "Cyberspionage",
                }

            );

            //Seedad Segments
            modelB.Entity<SegmentModel>().HasData(

                // Segments for category 1
                new SegmentModel
                {
                    Id = 1,
                    Name = "Del 1",
                    CategoryId = 1
                },

                new SegmentModel
                {
                    Id = 2,
                    Name = "Del 2",
                    CategoryId = 1
                },

                new SegmentModel
                {
                    Id = 3,
                    Name = "Del 3",
                    CategoryId = 1
                },

                // Segments for category 2
                new SegmentModel
                {
                    Id = 4,
                    Name = "Del 1",
                    CategoryId = 2
                },

                new SegmentModel
                {
                    Id = 5,
                    Name = "Del 2",
                    CategoryId = 2
                },

                new SegmentModel
                {
                    Id = 6,
                    Name = "Del 3",
                    CategoryId = 2
                },

                new SegmentModel
                {
                    Id = 7,
                    Name = "Del 4",
                    CategoryId = 2
                },

                // Segments for category 3
                new SegmentModel
                {
                    Id = 8,
                    Name = "Del 1",
                    CategoryId = 3
                },

                new SegmentModel
                {
                    Id = 9,
                    Name = "Del 2",
                    CategoryId = 3
                },

                new SegmentModel
                {
                    Id = 10,
                    Name = "Del 3",
                    CategoryId = 3
                },

                new SegmentModel
                {
                    Id = 11,
                    Name = "Del 4",
                    CategoryId = 3
                }

            );

            //Seedad Subcategories
            modelB.Entity<SubcategoryModel>().HasData(

                // Category 1
                // subcategories for segment 1
                new SubcategoryModel
                {
                    Id = 1,
                    Name = "Kreditkortsbedrägeri",
                    SegmentId = 1

                },

                new SubcategoryModel
                {
                    Id = 2,
                    Name = "Romansbedrägeri",
                    SegmentId = 1

                },

                new SubcategoryModel
                {
                    Id = 3,
                    Name = "Investeringsbedrägeri",
                    SegmentId = 1

                },

                new SubcategoryModel
                {
                    Id = 4,
                    Name = "Telefonbedrägeri",
                    SegmentId = 1

                },

                // subcategories for segment 2
                new SubcategoryModel
                {
                    Id = 5,
                    Name = "Bedrägerier i hemmet",
                    SegmentId = 2

                },

                new SubcategoryModel
                {
                    Id = 6,
                    Name = "Identitetsstöld",
                    SegmentId = 2

                },

                new SubcategoryModel
                {
                    Id = 7,
                    Name = "Nätfiske och bluffmejl",
                    SegmentId = 2

                },

                new SubcategoryModel
                {
                    Id = 8,
                    Name = "Investeringsbedrägeri på nätet",
                    SegmentId = 2

                },

                // subcategories for segment 3
                new SubcategoryModel
                {
                    Id = 9,
                    Name = "Abonnemangsfällor och falska fakturor",
                    SegmentId = 3

                },

                new SubcategoryModel
                {
                    Id = 10,
                    Name = "Ransomware",
                    SegmentId = 3

                },

                new SubcategoryModel
                {
                    Id = 11,
                    Name = "Statistik och förhållningssätt",
                    SegmentId = 3

                },

                // Category 2
                // subcategories for segment 1

                new SubcategoryModel
                {
                    Id = 12,
                    Name = "Digital säkerhet på företag",
                    SegmentId = 4

                },

                new SubcategoryModel
                {
                    Id = 13,
                    Name = "Risker och beredskap",
                    SegmentId = 4

                },

                new SubcategoryModel
                {
                    Id = 14,
                    Name = "Aktörer inom cyberbrott",
                    SegmentId = 4

                },

                new SubcategoryModel
                {
                    Id = 15,
                    Name = "Ökad digital närvaro och distansarbete",
                    SegmentId = 4

                },

                new SubcategoryModel
                {
                    Id = 16,
                    Name = "Cyberangrepp mot känsliga sektorer",
                    SegmentId = 4

                },

                new SubcategoryModel
                {
                    Id = 17,
                    Name = "Cyberrånet mot Mersk",
                    SegmentId = 4

                },


                // Category 2
                // subcategories for segment 2
                new SubcategoryModel
                {
                    Id = 18,
                    Name = "Social engineering",
                    SegmentId = 5

                }



            );


            //Seeding Subcategories
            modelB.Entity<QuestionModel>().HasData(

                // Category 1
                // Segment 1
                // Question for subcategory 1
                new QuestionModel
                {
                    Id = 1,
                    Title = "Du får ett oväntat telefonsamtal från någon som påstår sig vara från din bank. Personen ber dig bekräfta ditt kontonummer och lösenord för att säkerställa din kontos säkerhet efter en påstådd säkerhetsincident. Hur bör du tolka denna situation?",
                    SubcategoryId = 1

                },

                // Question for subcategory 2
                new QuestionModel
                {
                    Id = 2,
                    Title = "Efter flera månader av daglig kommunikation med någon du träffade på en datingsida, börjar personen berätta om en plötslig finansiell kris och ber om din hjälp genom att överföra pengar. Vad indikerar detta mest sannolikt?",
                    SubcategoryId = 2

                },

                // Question for subcategory 3
                new QuestionModel
                {
                    Id = 3,
                    Title = "Du får ett e-postmeddelande/samtal om ett exklusivt erbjudande att investera i ett startup-företag som påstås ha en revolutionerande ny teknologi, med garantier om exceptionellt hög avkastning på mycket kort tid. Hur bör du förhålla dig till erbjudandet?",
                    SubcategoryId = 3

                },

                // Question for subcategory 4
                new QuestionModel
                {
                    Id = 4,
                    Title = "Du får ett e-postmeddelande/samtal om ett exklusivt erbjudande att investera i ett startup-företag som påstås ha en revolutionerande ny teknologi, med garantier om exceptionellt hög avkastning på mycket kort tid. Hur bör du förhålla dig till erbjudandet?",
                    SubcategoryId = 4

                },


                // Category 2
                // Segment 1
                // Question for subcategory 1

                new QuestionModel
                {
                    Id = 5,
                    Title = "Du får ett e-postmeddelande/samtal om ett exklusivt erbjudande att investera i ett startup-företag som påstås ha en revolutionerande ny teknologi, med garantier om exceptionellt hög avkastning på mycket kort tid. Hur bör du förhålla dig till erbjudandet?",
                    SubcategoryId = 1

                },


            );

        }
    }
}
