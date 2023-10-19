using CreateApi.Model;
namespace CreateApi.NewFolder
{
    public static class Utility
    {
        private static List<SpeackerModel> _speakers = new List<SpeackerModel>()
        {
             new SpeackerModel()
            {
                Email = "speaker1@mail.com",
                FirstName = "FirstName1",
                LastName = "LastName1",
                Id = 1
            },
        new SpeackerModel()
        {
            Email = "mattia@mail.com",
                FirstName = "Mattia",
                LastName = "Ligreci",
                Id = 2
            },

        new SpeackerModel()
        {
                Email = "fede@mail.com",
                FirstName = "Federico",
                LastName = "Cassera",
                Id = 3
            },

        new SpeackerModel()
        {
            Email = "lollo@mail.com",
                FirstName = "Lorenzo",
                LastName = "Pioggia",
                Id = 4
            }
    };
 }


} 

