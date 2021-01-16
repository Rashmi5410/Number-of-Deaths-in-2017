using System;
using static System.Console;

namespace Bme121
{
    public partial class CauseOfDeathInfo
    {
    
        public string diseaseType; 
        public string yearOfDeath;
        public string ageRange; 
        public string sex;
        public int numOfDeaths;
        public double percentOfDeaths; 
        public double mortality;
    
    public CauseOfDeathInfo( string diseaseType, string yearOfDeath, string ageRange,
                            string sex,int numOfDeaths, double percentOfDeaths, 
                            double mortality)
    {
        this.diseaseType=diseaseType;
        this.yearOfDeath= yearOfDeath;
        this.ageRange= ageRange;
        this.sex = sex;
        this.numOfDeaths = numOfDeaths;
        this.percentOfDeaths= percentOfDeaths;
        this.mortality= mortality;
    }
    
    public override string ToString()
    {
        return$"{diseaseType}, {yearOfDeath}, {ageRange}, {sex}, {numOfDeaths}, {percentOfDeaths}, {mortality}";
    }
    
    }
    
    static partial class Program
    {
        static void Main( )
        {
            // Load the array of CauseOfDeathInfo objects.
            CauseOfDeathInfo[ ] stats = MakeStatsArray( );
            WriteLine( "stats.Length = {0}", stats.Length );
            
            int salmonellaDeaths = 0;
            int deathsIn2017 = 0;
            
            for(int i=0; i < stats.Length; i++)
            {
                if (stats[i].diseaseType == "Salmonella infections")
                {
                    salmonellaDeaths += stats[i].numOfDeaths; 
                }
            }
            
            for (int i=0; i < stats.Length; i++ )
            {
                if (stats[i].yearOfDeath == "2017"&& stats [i].ageRange == "15-24 years")
                {
                    deathsIn2017 += stats[i].numOfDeaths;
                }
            }
        
            WriteLine( "Total deaths due to Salmonella infection in 2009 to 2018 are " + salmonellaDeaths );
            WriteLine( "Total deaths for 2017 in the 15-24 years age range are " + (deathsIn2017/1000) + "," + (deathsIn2017 - (deathsIn2017/1000)*1000));
            
        }
    }
}
