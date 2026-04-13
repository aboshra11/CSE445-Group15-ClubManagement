using System;
using System.Collections.Generic;

public class FactService : IFactService
{
    private static Dictionary<string, string[]> facts = new Dictionary<string, string[]>
    {
        {"club", new string[] {
            "The first club was founded in the 1700s in London, England.",
            "Clubs help develop leadership and teamwork skills.",
            "There are over 1 million registered clubs in the United States.",
            "The oldest student club at ASU was founded in 1886."
        }},
        {"sports", new string[] {
            "Basketball was invented in 1891 by Dr. James Naismith.",
            "Soccer is the world's most popular sport with 4 billion fans.",
            "The Olympic Games originated in ancient Greece in 776 BC."
        }},
        {"technology", new string[] {
            "The first computer weighed over 27 tons.",
            "There are over 1.8 billion websites on the internet.",
            "The first smartphone was created by IBM in 1992."
        }},
        {"general", new string[] {
            "Club membership improves mental health!",
            "Joining a club can help build your professional network.",
            "Clubs provide a sense of community and belonging."
        }}
    };

    public string GetRandomFact(string category)
    {
        Random rand = new Random();

        if (string.IsNullOrEmpty(category))
            category = "general";

        category = category.ToLower();

        if (facts.ContainsKey(category))
        {
            string[] categoryFacts = facts[category];
            return categoryFacts[rand.Next(categoryFacts.Length)];
        }
        else
        {
            return $"No facts found for category '{category}'. Try: club, sports, technology, or general.";
        }
    }

    public string[] GetCategories()
    {
        List<string> categories = new List<string>(facts.Keys);
        return categories.ToArray();
    }
}