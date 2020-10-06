using System. Collections.Generic;
public class Collection
{
    public void LearnAboutList()
    {
        List<string> names = new List<string>();//{ "PraJwol","Shrestha","Kambang" } can be initialized here also
        names.Add("AShresthaPzl");
        names.Add("BShresthaPzl");
        names.Add("CShresthaPzl");
        names.Add("DShresthaPzl");

        names.Sort();
        
    }
    public void LearnAboutDictionary()
    {
        //Holds key value pair
        Dictionary<string, string> countryCapitas = new Dictionary<string, string>
        {
            ["Bhutan"] = "Thimpu",
            ["China"] = "Beijing"
        };
        countryCapitas.Add( "Nepal","Kathmandu");
        countryCapitas.Add( "Australia","Sydney");
        countryCapitas.Add( "USA","Washton DC");
        countryCapitas.Add( "Spain","Madrid");

    }
}