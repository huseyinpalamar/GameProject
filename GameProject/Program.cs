using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamer = new GamerManager(new UserValidationManager());
            gamer.NewRegistration(new Gamer {DateOfBrith=1999, FisrtName = "HÜSEYİN", LastName = "PALAMAR", Id = 1});

            AdminManager admin = new AdminManager(new AdminValidationManager());
            admin.NewRegistration(new User {DateOfBrith=1999,FisrtName="HÜSEYİN",LastName="PALAMAR",Id=1,IdentificationNumber=123456 });

            GameSaleManager gameSale = new GameSaleManager();
            gameSale.GameSale(new Game {GameName="CSGO",GamePrice=150,SerialNumber="1" },new Gamer {FisrtName="İlkay" });

            CampaignManager campaign = new CampaignManager();
            campaign.AddCampaign(new Campaign {CampaignName="Efsane Cuma",Id=2,CampaignDescription="Avantajlı urünleri kaçırmayın",CampaignDuration="18 Hazirana kadar Geçerli" });


            
        }
    }
}
