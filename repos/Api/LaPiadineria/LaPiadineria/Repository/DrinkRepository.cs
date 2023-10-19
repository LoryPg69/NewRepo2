using LaPiadineria.Models;
using LaPiadineriaApi.Models;

namespace LaPiadineriaApi.Repository
{
    public class DrinkRepository
    {
        public List<DrinkModel> Drink { get; set; }
        public static DrinkRepository Current { get; } = new DrinkRepository();

        public DrinkRepository()
        {

            Piada = new List<LaPiadineria.Models.DrinkModel>()
            {
                new LaPiadineria.Models.DrinkModel() {
                Id = 1,
                Name = "Superiore",
                Type = "Piada",
                Price = 7.90,
                Items = new List<ItemPiadaModel>()
                {
                    new ItemPiadaModel()
                    {
                        Id = 1,
                        Name="Culatta",

                    },
                    new ItemPiadaModel()
                    {
                        Id = 2,
                        Name="Squacquerone",

                    },

                    new ItemPiadaModel()
                    {
                        Id = 3,
                        Name="Pomodoro",

                    },

                    new ItemPiadaModel()
                    {
                        Id = 4,
                        Name="Rucola",

                    }

                }
                },

            new LaPiadineria.Models.DrinkModel()
            {
                Id = 2,
                Name = "Malga",
                Type = "Rotolo",
                Price = 5.90,
                Items = new List<ItemPiadaModel>()
                {
                    new ItemPiadaModel()
                    {
                        Id = 1,
                        Name="Tour Eiffel",

                    },
                    new ItemPiadaModel()
                    {
                        Id = 2,
                        Name="arc the triomphe ",

                    }

                }
            },
    

    
