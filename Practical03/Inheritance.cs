using System.Globalization;

namespace Practical03
{
    //Class Sponser with protected access modifier
    class Sponser
    {
        protected string owner = "Rakuteen";
    }
    //Class Team with private access modifier with extends class Sponser
    class Team : Sponser
    {
        private string teamName;
        //With accessors set the value of teamName and get the value of teamName
        public string TeamName
        {
            get { return teamName; }
            set { teamName = value; }
        }
        //Method printInfo to print the teamName and owner which return the string
        public string printInfo()
        {
           return "Team Name: " + teamName + " Owner: " + owner;
        }
    }
}
