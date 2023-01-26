using System.Diagnostics;
namespace botLol
{
    class Client : MouseOperations
    {

        private String path {get;set;}

        public Client(String path){
            this.path = path;
        }

        public void startClient(){
            Process.Start(@"C:\Riot Games\League of Legends\LeagueClient.exe");
        }

        public void connexion(){
            MouseOperations.SetCursorPosition(365,365); //Positionne la souris sur 
        }
        public void clickPlay(){

        }
        
    }
}